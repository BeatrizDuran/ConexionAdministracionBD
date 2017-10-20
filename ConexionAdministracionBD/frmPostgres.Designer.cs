namespace ConexionAdministracionBD
{
    partial class frmPostgres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvbasedatos = new System.Windows.Forms.DataGridView();
            this.dgvtablas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbasedatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbasedatos
            // 
            this.dgvbasedatos.AllowUserToAddRows = false;
            this.dgvbasedatos.AllowUserToDeleteRows = false;
            this.dgvbasedatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbasedatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbasedatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvbasedatos.Location = new System.Drawing.Point(0, 0);
            this.dgvbasedatos.Name = "dgvbasedatos";
            this.dgvbasedatos.ReadOnly = true;
            this.dgvbasedatos.Size = new System.Drawing.Size(240, 188);
            this.dgvbasedatos.TabIndex = 0;
            this.dgvbasedatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbasedatos_CellClick);
            // 
            // dgvtablas
            // 
            this.dgvtablas.AllowUserToAddRows = false;
            this.dgvtablas.AllowUserToDeleteRows = false;
            this.dgvtablas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvtablas.Location = new System.Drawing.Point(0, 194);
            this.dgvtablas.Name = "dgvtablas";
            this.dgvtablas.ReadOnly = true;
            this.dgvtablas.Size = new System.Drawing.Size(240, 188);
            this.dgvtablas.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Base Datos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tablas";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmPostgres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 394);
            this.Controls.Add(this.dgvtablas);
            this.Controls.Add(this.dgvbasedatos);
            this.Name = "frmPostgres";
            this.Text = "frmPostgres";
            this.Load += new System.EventHandler(this.frmPostgres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbasedatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtablas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbasedatos;
        private System.Windows.Forms.DataGridView dgvtablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}