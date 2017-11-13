using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ConexionAdministracionBD
{
    public partial class frmPostgres : Form
    {

        public static NpgsqlConnection con1;
        public frmPostgres(TreeView tree)
        {
            InitializeComponent();
            this.lista = tree;
        }
        private TreeView lista;
        private void frmPostgres_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < lista.Nodes.Count; j++)
            {
                tvPOSTGRES.Nodes.Add(lista.Nodes[j].ToString().Remove(0, 9));
            }
        }
        
        private void tvPOSTGRES_AfterSelect(object sender, TreeViewEventArgs e)
        {
            NpgsqlConnection con1 = AdminSesiones.npgsqlConnection;
            try
            {
                //Verificar la consulta para la selección de la base de datos y muestre las tablas.
                string bd = "SELECT tablename FROM pg_catalog.pg_tables WHERE schemaname != '"+tvPOSTGRES.SelectedNode.Text+"' AND schemaname != 'public'";
                NpgsqlCommand comd = new NpgsqlCommand(bd, con1);//comando
                con1.Open();
                comd.Connection = con1;
                comd.ExecuteNonQuery();
                NpgsqlDataReader lector = comd.ExecuteReader();
                //dgvTABLAS.Rows.Clear();
                //dgvTABLAS.Columns.Clear();
                //dgvTABLAS.Columns.Add("Tablas", "Column");
                if(tvPOSTGRES.Nodes[tvPOSTGRES.SelectedNode.Index].Nodes.Count >= 1)
                {
                    tvPOSTGRES.Nodes[tvPOSTGRES.SelectedNode.Index].Nodes.Clear();
                }
                else
                {
                    while (lector.Read())
                    {
                        tvPOSTGRES.Nodes[tvPOSTGRES.SelectedNode.Index].Nodes.Add(lector.GetString(0));
                    }
                }
                lector.Close();
                con1.Close();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
