namespace ConexionAdministracionBD
{
    partial class frmSQLSERVER
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
            this.tvSQLSERVER = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvSQLSERVER
            // 
            this.tvSQLSERVER.Location = new System.Drawing.Point(0, 0);
            this.tvSQLSERVER.Name = "tvSQLSERVER";
            this.tvSQLSERVER.Size = new System.Drawing.Size(214, 356);
            this.tvSQLSERVER.TabIndex = 1;
            this.tvSQLSERVER.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSQLSERVER_AfterSelect);
            // 
            // frmSQLSERVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 358);
            this.Controls.Add(this.tvSQLSERVER);
            this.Name = "frmSQLSERVER";
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.frmSQLSERVER_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvSQLSERVER;
    }
}