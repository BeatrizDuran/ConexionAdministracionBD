using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionAdministracionBD
{
    public partial class Base_de_datos : Form
    {
        public static MySqlConnection con1;
        public Base_de_datos(TreeView db)
        //public Base_de_datos(DataGridView tables)
        {
            InitializeComponent();
            this.lista = db;
           //this.tablitas = tables;          
        }
        private TreeView lista;
        //private DataGridView tablitas;
        private void Base_de_datos_Load(object sender, EventArgs e)
        {
           // for (int i = 0; i < tablitas.Rows.Count-1; i++)
                for (int j = 0; j < lista.Nodes.Count; j++)
            {
                //dgvBASEDATOS.Rows.Add(tablitas[0,i].Value.ToString());
                    tvBASEDATOS.Nodes.Add(lista.Nodes[j].ToString().Remove(0,9));              
            }
        }
        private void tvBASEDATOS_AfterSelect(object sender, TreeViewEventArgs e)
        //private void dgvBASEDATOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection con1 = AdminSesiones.con;
            try
            {
                //string bd = "USE " + dgvBASEDATOS.CurrentCell.Value.ToString() + "; SHOW TABLES";
                string bd = "USE " + tvBASEDATOS.SelectedNode.Text + "; SHOW TABLES";
                MySqlCommand comd = new MySqlCommand(bd, con1);//comando
                con1.Open();
                comd.Connection = con1;
                comd.ExecuteNonQuery();
                MySqlDataReader lector = comd.ExecuteReader();
                dgvTABLAS.Rows.Clear();
                dgvTABLAS.Columns.Clear();
                dgvTABLAS.Columns.Add("Tablas", dgvBASEDATOS.CurrentCell.Value.ToString());
                if(tvBASEDATOS.Nodes[tvBASEDATOS.SelectedNode.Index].Nodes.Count >= 1)
                {
                    tvBASEDATOS.Nodes[tvBASEDATOS.SelectedNode.Index].Nodes.Clear();
                    //dgvTABLAS.Rows.Add(lector.GetValue(0).ToString());
                }else
                {
                    while (lector.Read())
                    {
                      tvBASEDATOS.Nodes[tvBASEDATOS.SelectedNode.Index].Nodes.Add(lector.GetString(0));
                    }
                }
                lector.Close();
                con1.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void dgvBASEDATOS_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //dgvBASEDATOS_CellClick(sender, e);
        }
        
    }
}
