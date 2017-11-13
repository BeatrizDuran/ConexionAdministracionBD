namespace ConexionAdministracionBD
{
    partial class frmSQLite
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
            this.tvSQLite = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvSQLite
            // 
            this.tvSQLite.Location = new System.Drawing.Point(3, 2);
            this.tvSQLite.Name = "tvSQLite";
            this.tvSQLite.Size = new System.Drawing.Size(240, 334);
            this.tvSQLite.TabIndex = 0;
            this.tvSQLite.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSQLite_AfterSelect);
            // 
            // frmSQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 338);
            this.Controls.Add(this.tvSQLite);
            this.Name = "frmSQLite";
            this.Text = "SQLite";
            this.Load += new System.EventHandler(this.frmSQLite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvSQLite;
    }
}