namespace ConexionAdministracionBD
{
    partial class Base_de_datos
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
            this.dgvBASEDATOS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTABLAS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvBASEDATOS = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBASEDATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTABLAS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBASEDATOS
            // 
            this.dgvBASEDATOS.AllowUserToAddRows = false;
            this.dgvBASEDATOS.AllowUserToDeleteRows = false;
            this.dgvBASEDATOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBASEDATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBASEDATOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvBASEDATOS.Location = new System.Drawing.Point(1, 0);
            this.dgvBASEDATOS.Name = "dgvBASEDATOS";
            this.dgvBASEDATOS.ReadOnly = true;
            this.dgvBASEDATOS.Size = new System.Drawing.Size(182, 216);
            this.dgvBASEDATOS.TabIndex = 0;
            this.dgvBASEDATOS.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBASEDATOS_CellEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Base de datos";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgvTABLAS
            // 
            this.dgvTABLAS.AllowUserToAddRows = false;
            this.dgvTABLAS.AllowUserToDeleteRows = false;
            this.dgvTABLAS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTABLAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTABLAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvTABLAS.Location = new System.Drawing.Point(1, 222);
            this.dgvTABLAS.Name = "dgvTABLAS";
            this.dgvTABLAS.ReadOnly = true;
            this.dgvTABLAS.Size = new System.Drawing.Size(182, 220);
            this.dgvTABLAS.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Tablas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tvBASEDATOS
            // 
            this.tvBASEDATOS.Location = new System.Drawing.Point(189, 0);
            this.tvBASEDATOS.Name = "tvBASEDATOS";
            this.tvBASEDATOS.Size = new System.Drawing.Size(214, 230);
            this.tvBASEDATOS.TabIndex = 3;
            this.tvBASEDATOS.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBASEDATOS_AfterSelect);
            // 
            // Base_de_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 448);
            this.Controls.Add(this.tvBASEDATOS);
            this.Controls.Add(this.dgvTABLAS);
            this.Controls.Add(this.dgvBASEDATOS);
            this.Name = "Base_de_datos";
            this.Text = "Base_de_datos";
            this.Load += new System.EventHandler(this.Base_de_datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBASEDATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTABLAS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBASEDATOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvTABLAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TreeView tvBASEDATOS;
    }
}