using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ConexionAdministracionBD
{
    public partial class frmSQLSERVER : Form
    {
        public static SqlConnection con;
        public frmSQLSERVER(TreeView tree)
        {
            InitializeComponent();
            this.listita = tree;
        }
        private TreeView listita;
        private void frmSQLSERVER_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < listita.Nodes.Count; j++)
            {
                tvSQLSERVER.Nodes.Add(listita.Nodes[j].ToString().Remove(0, 9));
            }
        }

        private void tvSQLSERVER_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SqlConnection con1 = AdminSesiones.sqlcon;
            try
            {
                string bd = "USE " + tvSQLSERVER.SelectedNode.Text + "; SELECT TABLE_NAME FROM INFORMATION_SCHEMA.tables";
               SqlCommand comd = new SqlCommand(bd, con1);//comando
                con1.Open();
                comd.Connection = con1;
                comd.ExecuteNonQuery();
                SqlDataReader lector = comd.ExecuteReader();
                //dgvTABLAS.Rows.Clear();
                //dgvTABLAS.Columns.Clear();
                //dgvTABLAS.Columns.Add("Tablas", "Column");
                if (tvSQLSERVER.Nodes[tvSQLSERVER.SelectedNode.Index].Nodes.Count >= 1)
                {
                    tvSQLSERVER.Nodes[tvSQLSERVER.SelectedNode.Index].Nodes.Clear();
                }
                else
                {
                    while (lector.Read())
                    {
                        tvSQLSERVER.Nodes[tvSQLSERVER.SelectedNode.Index].Nodes.Add(lector.GetString(0));
                    }
                }
                lector.Close();
                con1.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
