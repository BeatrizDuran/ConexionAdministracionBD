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
    public partial class frmMySql : Form

    {
        public static MySqlConnection con1;
        public frmMySql(TreeView tree)
        {
            InitializeComponent();
            this.lista = tree;         
        }
        private TreeView lista;
        private void frmMySql_Load_1(object sender, EventArgs e)
        {
                for (int j = 0; j < lista.Nodes.Count; j++)
            {
                    tvMysql.Nodes.Add(lista.Nodes[j].ToString().Remove(0,9));              
            }
        }
        private void tvBASEDATOS_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MySqlConnection con1 = AdminSesiones.con;
            try
            {
                string bd = "USE " + tvMysql.SelectedNode.Text + "; SHOW TABLES";
                MySqlCommand comd = new MySqlCommand(bd, con1);//comando
                con1.Open();
                comd.Connection = con1;
                comd.ExecuteNonQuery();
                MySqlDataReader lector = comd.ExecuteReader();
                if(tvMysql.Nodes[tvMysql.SelectedNode.Index].Nodes.Count >= 1)
                    {
                    tvMysql.Nodes[tvMysql.SelectedNode.Index].Nodes.Clear();
                }else
                {
                    while (lector.Read())
                    {
                      tvMysql.Nodes[tvMysql.SelectedNode.Index].Nodes.Add(lector.GetString(0));
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

        private void tvMysql_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MySqlConnection con1 = AdminSesiones.con;
            try
            {
                string bd = "USE " + tvMysql.SelectedNode.Text + "; SHOW TABLES";
                MySqlCommand comd = new MySqlCommand(bd, con1);//comando
                con1.Open();
                comd.Connection = con1;
                comd.ExecuteNonQuery();
                MySqlDataReader lector = comd.ExecuteReader();
                if (tvMysql.Nodes[tvMysql.SelectedNode.Index].Nodes.Count >= 1)
                {
                    tvMysql.Nodes[tvMysql.SelectedNode.Index].Nodes.Clear();
                }
                else
                {
                    while (lector.Read())
                    {
                        tvMysql.Nodes[tvMysql.SelectedNode.Index].Nodes.Add(lector.GetString(0));
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

    }
}
