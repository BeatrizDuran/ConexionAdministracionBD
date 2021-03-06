﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Npgsql;
using System.Data.SQLite;
using MongoDB.Driver.Core;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;

namespace ConexionAdministracionBD
{
    public partial class AdminSesiones : Form
    {
        public static MySqlConnection con;
        public static MySqlCommand comd;
        public string cadena;
        public AdminSesiones()
        {
            InitializeComponent();
        }
        public static IMongoClient mongo;
        public static IMongoDatabase db ;
        /// <summary>
        /// Botones con la propiedad enabled false
        /// </summary>           
        private void botones()
        {
            txtPASSWORD.Visible = false;
            txtHOST.Visible = false;
            txtROOT.Visible = false;
            cmbPRUEBA.Visible = false;
            lblBASEDATOS.Visible = false;
            duPUERTO.Visible = false;          
            lblHOST.Visible = false;
            lblPASSWORD.Visible = false;
            lblPUERTO.Visible = false;
            lblUSUARIO.Visible = false;
            duPUERTO.Visible = false;
            lblARCHIVO.Visible = true;
            btnBROWSER.Visible = true;
            txtARCHIVO.Visible = true;
        }
        /// <summary>
        /// botones con la propiedad en verdadero
        /// </summary>
        private void botonesTRUE()
        {
            txtPASSWORD.Visible = true;
            txtROOT.Visible = true;
            txtHOST.Visible = true;
            duPUERTO.Visible = true;
            cmbPRUEBA.Visible = true;
            lblHOST.Visible = true;
            lblPASSWORD.Visible = true;
            lblPUERTO.Visible = true;
            lblUSUARIO.Visible = true;
            lblARCHIVO.Visible = false;
            txtARCHIVO.Visible = false;
            btnBROWSER.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox1.Focus();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {        
            switch (comboBox1.SelectedIndex.ToString())
            {
                case "0"://MYSQL....................
                    botonesTRUE();                 
                    txtHOST.Text = "127.0.0.1";
                    txtROOT.Text = "root";
                    txtPASSWORD.Clear();
                    duPUERTO.Text = "3306";                 
                    break;
                case "1"://POSTGRES.......................
                    botonesTRUE();
                    txtHOST.Text = "127.0.0.1";
                    txtROOT.Text = "postgres";
                    txtPASSWORD.Clear();
                    duPUERTO.Text = "5432";                  
                    break;
                case "2"://SQLSERVER......................
                    botonesTRUE();
                    txtHOST.Text = "BEATRIZDURAN-PC";
                    txtROOT.Text = "sa";
                    txtPASSWORD.Clear();
                    duPUERTO.Text = "1433";             
                    break;
                case "3":
                    //CONECTAR A SQLITE
                    botones();
                    txtHOST.Text = "127.0.0.1";
                    duPUERTO.Text = "3306";                   
                    break;
                case "4":
                    //CONECTAR A MONGO............................
                    botonesTRUE();
                    txtPASSWORD.Clear();
                    txtROOT.Text = "";
                    txtHOST.Text = "127.0.0.1";
                    duPUERTO.Text = "27017";
                    break;
                case "5":
                    txtHOST.Text = "127.0.0.1";
                    txtPASSWORD.Clear();
                    break;
            }
        }
        private void btnCONECTAR_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex.ToString())
            {
                //................................MYSQL..................................
                case "0":
                    if (txtPASSWORD.Text.Trim() == "" || txtROOT.Text.Trim() == ""|| duPUERTO.Text.Trim()=="") 
                    {
                        MessageBox.Show("Hay campos vacios", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cmbPRUEBA.Text.Trim() == "")
                        {
                            cadena = "Server = " + txtHOST.Text + "; Port =" + duPUERTO.Text + "; username = " + txtROOT.Text + "; password = " + txtPASSWORD.Text + ";";
                            con = new MySqlConnection(cadena);
                            try
                            {
                                string query = "SHOW DATABASES";
                                comd = new MySqlCommand(query, con);
                                con.Open();
                                comd.Connection = con;
                                comd.ExecuteNonQuery();
                                MySqlDataReader lector = comd.ExecuteReader();
                                TreeView view = new TreeView();
                                while (lector.Read())
                                {
                                    view.Nodes.Add(lector.GetValue(0).ToString());
                                }
                                lector.Close();
                                con.Close();
                                VentanaPrincipal.SNF(view);
                                this.Close();
                            }
                            catch (MySqlException error)
                            {
                                MessageBox.Show(error.ToString());
                            }
                        }
                        else
                        {

                            cadena = "Server = " + txtHOST.Text + "; Port =" + duPUERTO.Text + "; username = " + txtROOT.Text + "; password = " + txtPASSWORD.Text + "; database = " + cmbPRUEBA.Text + ";";
                            con = new MySqlConnection(cadena);
                            try
                            {
                                TreeView view = new TreeView();
                                view.Nodes.Add(cmbPRUEBA.Text);
                                con.Open();
                                string QUERY = "SHOW DATABASES LIKE '" + cmbPRUEBA.Text + "';";
                                MySqlCommand COM = new MySqlCommand(QUERY, con);
                                COM.ExecuteNonQuery();
                                MySqlDataReader lector = COM.ExecuteReader();
                                while (lector.Read())
                                {
                                    view.Nodes.Add(lector.GetValue(0).ToString());
                                }

                                lector.Close();
                                con.Close();
                                VentanaPrincipal.SNF(view);
                                this.Close();
                            }
                            catch (MySqlException error)
                            {
                                MessageBox.Show(error.ToString());
                            }
                        }
                    }
                    break;
                //........................................POSTGRES.........................................
                case "1":
                    if (txtPASSWORD.Text.Trim() == "" || txtROOT.Text.Trim() == "") //check password and user
                    {
                        MessageBox.Show("Hay campos vacios", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cmbPRUEBA.Text == "")
                        {
                            cadena = "Server=" + txtHOST.Text + "; Port=" + duPUERTO.Text + "; User id= " + txtROOT.Text + "; Password= " + txtPASSWORD.Text + "; Database= " + cmbPRUEBA.Text;
                            NpgsqlConnection con3 = new NpgsqlConnection(cadena);
                            try
                            {
                                string q = "SELECT datname FROM pg_database WHERE datistemplate= false;";
                                NpgsqlCommand com3 = new NpgsqlCommand(q, con3);
                                con3.Open();
                                com3.ExecuteNonQuery();
                                NpgsqlDataReader lector3 = com3.ExecuteReader();
                                TreeView view3 = new TreeView();
                                while (lector3.Read())
                                {
                                    view3.Nodes.Add(lector3.GetValue(0).ToString());
                                }
                                lector3.Close();
                                //string q1 = "SELECT tablename FROM pg_tables WHERE schemaname ='public'";//mostrar tablas
                                
                                VentanaPrincipal.SNF(view3);
                                this.Close();
                            }
                            catch (MySqlException error)
                            {
                                MessageBox.Show(error.ToString());
                            }
                        }
                        else
                        {
                            cadena = "Server=" + txtHOST.Text + "; Port=" + duPUERTO.Text + "; User id= " + txtROOT.Text + "; Password= " + txtPASSWORD.Text + "; Database= '" + cmbPRUEBA.Text + "';";
                            NpgsqlConnection con2 = new NpgsqlConnection(cadena);
                            try
                            {
                                string q = "SELECT datname FROM pg_database WHERE datname = '" + cmbPRUEBA.Text + "';";
                                NpgsqlCommand com = new NpgsqlCommand(q, con2);
                                con2.Open();
                                com.ExecuteNonQuery();
                                NpgsqlDataReader lector = com.ExecuteReader();
                                TreeView view = new TreeView();
                                while (lector.Read())
                                {
                                    view.Nodes.Add(lector.GetValue(0).ToString());
                                }
                                lector.Close();
                               // string q1 = "SELECT tablename FROM pg_tables WHERE schemaname ='public'"; //mostrar tablas
                               
                                VentanaPrincipal.SNF(view);
                                this.Close();

                            }
                            catch (NpgsqlException error)
                            {
                                MessageBox.Show("Error al conectar" + error);
                            }
                        }
                    }
                    break;
                //.....................................SQL SERVER.........................................
                case "2":
                    if (txtPASSWORD.Text.Trim() == "" || txtROOT.Text.Trim() == "") //check password and user
                    {
                        MessageBox.Show("Hay campos vacios", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cmbPRUEBA.Text == "")
                        {
                            cadena = @"Data Source=" + txtHOST.Text + ";Integrated Security=SSPI;Initial Catalog=" + cmbPRUEBA.Text + ";";
                            SqlConnection conn = new SqlConnection(cadena);
                            try
                            {
                                string l = "SELECT name FROM master.dbo.sysdatabases";
                                SqlCommand com = new SqlCommand(l, conn);
                                conn.Open();
                                com.ExecuteNonQuery();
                                SqlDataReader lector = com.ExecuteReader();
                                DataGridView view = new DataGridView();
                                view.Columns.Add("Column1", "Column2");
                                while (lector.Read())
                                {
                                    view.Rows.Add(lector.GetValue(0).ToString());
                                }
                                lector.Close();
                                // MessageBox.Show("Conexión exitosa");
                                // VentanaPrincipal.SNF(view);
                                this.Close();
                            }
                            catch (SqlException error)
                            {
                                MessageBox.Show("Error al conectar" + error);
                            }
                        }
                        else
                        {
                            cadena = @"Data Source=" + txtHOST.Text + ";Integrated Security=SSPI;Initial Catalog=" + cmbPRUEBA.Text + ";";
                            SqlConnection conn = new SqlConnection(cadena);
                            try
                            {
                               string  k = "EXEC sp_helpdb '" + cmbPRUEBA.Text + "'";
                                SqlCommand com1 = new SqlCommand(k, conn);
                                conn.Open();
                                com1.ExecuteNonQuery();
                                SqlDataReader lector1 = com1.ExecuteReader();
                                TreeView view1 = new TreeView();
                                while (lector1.Read())
                                {
                                    view1.Nodes.Add(lector1.GetValue(0).ToString());
                                }
                                lector1.Close();
                                //string k1 = "SELECT name FROM sysobjects WHERE xtype='u'"; mostrar tablas
                               
                                VentanaPrincipal.SNF(view1);
                                this.Close();
                            }
                            catch (MySqlException error)
                            {
                                MessageBox.Show(error.ToString());
                            }
                        }
                    }
                    break;
                case "3":
                    //...............................CONECTAR SQLITE.......................
                    if (cmbPRUEBA.Text.Trim() == "")
                        MessageBox.Show("Hay un campo vacio","Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                    else
                    {
                        try
                        {
                            SQLiteConnection sqliteCON = new SQLiteConnection("Data Source = " + cmbPRUEBA.Text);
                            sqliteCON.Open();
                            MessageBox.Show("Conectado a base de datos");
                            sqliteCON.Close();
                        }
                        catch (SQLiteException sqlite)
                        {
                            MessageBox.Show(""+sqlite);
                        }
                    }
                        break;
                case "4":
                    //......................CONEXIÓN A MONGODB........................                  
                    try
                    {
                        string cadena = "mongodb://"+txtHOST.Text+":" + duPUERTO.Text + "";
                        mongo = new MongoClient(cadena);
                       
                      // MongoServerAddress server = new MongoServerAddress
                        mongo.GetDatabase(cmbPRUEBA.Text);
                        if (mongo.Cluster.Description.State.ToString() == "Disconnected")
                        {
                            MessageBox.Show("Error al conectar");
                        }
                        else
                        {
                            MessageBox.Show("Exito al conectar!");
                        }
                       // db = mongo.GetDatabase("test");
                       //MessageBox.Show(mongo.ToString());

                    }catch(MongoException error)
                    {
                        MessageBox.Show(error.ToString());
                    }
                    break;        
            }    
            }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Database (*.db)|*.db";
            if (open.ShowDialog()==DialogResult.OK)
            {
                cmbPRUEBA.Text = open.FileName;
            }
        }
        /// <summary>
        /// boton de prueba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPRUEBA_Click(object sender, EventArgs e)
        {
            cmbPRUEBA.Items.Clear();
            switch (comboBox1.SelectedIndex.ToString())
            {
                //......................................MYSQL............................................
                case "0":
                    try
                    {
                        if (txtHOST.Text.Trim() == "" || txtROOT.Text.Trim() == "" || txtPASSWORD.Text.Trim() == "")
                        {
                            MessageBox.Show("Es necesario llenar los campos");
                        }
                        else
                        {
                            string caden = "Server = " + txtHOST.Text + "; Port =" + duPUERTO.Text + "; username = " + txtROOT.Text + "; password = " + txtPASSWORD.Text + "; database = " + cmbPRUEBA.Text + ";";
                            if (cmbPRUEBA.Text == "")
                            {
                                MySqlConnection con = new MySqlConnection(caden);
                                string query = "SHOW DATABASES";// LIKE'"+txtBASEDEDATOS.Text+"'";
                                MySqlCommand com = new MySqlCommand(query, con);
                                con.Open();
                                com.ExecuteNonQuery();
                                MySqlDataReader lector = com.ExecuteReader();
                                MessageBox.Show("Conexión exitosa");
                                while (lector.Read())
                                {
                                    cmbPRUEBA.Items.Add(lector.GetValue(0).ToString());
                                }
                                lector.Close();
                                con.Close();
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error :" + error);
                    }

                    break;
                //..................POSTGRES....................................................
                case "1":
                    try
                    {
                        if (txtHOST.Text.Trim() == "" || txtROOT.Text.Trim() == "" || txtPASSWORD.Text.Trim() == "")
                        {
                            MessageBox.Show("Es necesario llenar los campos");
                        }
                        else
                        {
                            string ca = "Server=" + txtHOST.Text + "; Port=" + duPUERTO.Text + "; User id= " + txtROOT.Text + "; Password= " + txtPASSWORD.Text + "; Database= " + cmbPRUEBA.Text;
                            if (cmbPRUEBA.Text == "")
                            {
                                NpgsqlConnection con1 = new NpgsqlConnection(ca);
                                string query1 = "SELECT datname FROM pg_database WHERE datistemplate= false;";// LIKE'"+txtBASEDEDATOS.Text+"'";
                                NpgsqlCommand ncm1 = new NpgsqlCommand(query1, con1);
                                con1.Open();
                                ncm1.ExecuteNonQuery();
                                NpgsqlDataReader lector1 = ncm1.ExecuteReader();
                                MessageBox.Show("Conexión exitosa");
                                while (lector1.Read())
                                {
                                    cmbPRUEBA.Items.Add(lector1.GetValue(0).ToString());
                                }
                                lector1.Close();
                                con1.Close();
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error :" + error);
                    }
                    break;
                //.........................SQLSERVER...........................................
                case "2":
                    try
                    {
                        if (txtHOST.Text.Trim() == "" || txtROOT.Text.Trim() == "" || txtPASSWORD.Text.Trim() == "")
                        {
                            MessageBox.Show("Es necesario llenar los campos");
                        }
                        else
                        {
                            string cade = @"Data Source=" + txtHOST.Text + ";Integrated Security=SSPI;Initial Catalog=" + cmbPRUEBA.Text + ";";
                            if (cmbPRUEBA.Text == "")
                            {
                                SqlConnection con1 = new SqlConnection(cade);
                                string query1 = "SELECT name FROM master.dbo.sysdatabases";
                                SqlCommand ncm1 = new SqlCommand(query1, con1);
                                con1.Open();
                                ncm1.ExecuteNonQuery();
                                SqlDataReader lector1 = ncm1.ExecuteReader();
                                MessageBox.Show("Conexión exitosa");
                                while (lector1.Read())
                                {
                                    cmbPRUEBA.Items.Add(lector1.GetValue(0).ToString());
                                }
                                lector1.Close();
                                con1.Close();
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error :" + error);
                    }
                    break;
                //...............................SQLITE............................
                case "3":
                    if (cmbPRUEBA.Text.Trim() == "")
                        MessageBox.Show("Hay un campo vacio", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        try
                        {
                            SQLiteConnection sqliteCON = new SQLiteConnection("Data Source = " + cmbPRUEBA.Text);
                            sqliteCON.Open();
                            MessageBox.Show("Conectado a base de datos");
                            sqliteCON.Close();
                        }
                        catch (SQLiteException sqlite)
                        {
                            MessageBox.Show("Error al conectar" + sqlite);
                        }
                    }
                    break;
                    //........................MONGODB..............................
                case "4":
                    string cadena = "mongodb://" + txtHOST.Text + ":" + duPUERTO.Text + "";
                    mongo = new MongoClient(cadena);

                    // MongoServerAddress server = new MongoServerAddress
                    mongo.GetDatabase(cmbPRUEBA.Text);
                    if (mongo.Cluster.Description.State.ToString() == "Disconnected")
                    {
                        MessageBox.Show("Error al conectar");
                    }
                    else
                    {
                        MessageBox.Show("Exito al conectar!");
                    }
                    break;
            }
            }
    }
    }

