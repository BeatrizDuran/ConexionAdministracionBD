using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ConexionAdministracionBD
{
    public partial class frmSQLite : Form
    {
        public static SQLiteConnection sqlcon1;
        public frmSQLite(TreeView tree)
        {
            InitializeComponent();
            this.listaa = tree;
        }
        private TreeView listaa;
        private void frmSQLite_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < listaa.Nodes.Count; j++)
            {
                tvSQLite.Nodes.Add(listaa.Nodes[j].ToString().Remove(0, 9));
            }
        }
        private void tvSQLite_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SQLiteConnection sqlcon1 = AdminSesiones.sqlitecon;
            try
            {
                string bd = "select name from sqlite_master where type = 'table'";
                SQLiteCommand comd = new SQLiteCommand();//comando
                comd.CommandText = bd;
                sqlcon1.Open();
                comd.Connection = sqlcon1;
                comd.ExecuteNonQuery();
                SQLiteDataReader lector = comd.ExecuteReader();
                if (tvSQLite.Nodes[tvSQLite.SelectedNode.Index].Nodes.Count >= 1)
                {
                    tvSQLite.Nodes[tvSQLite.SelectedNode.Index].Nodes.Clear();
                }
                else
                {
                    while (lector.Read())
                    {
                        tvSQLite.Nodes[tvSQLite.SelectedNode.Index].Nodes.Add(lector.GetString(0));
                    }
                }
                lector.Close();
                sqlcon1.Close();
            }
            catch (SQLiteException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
