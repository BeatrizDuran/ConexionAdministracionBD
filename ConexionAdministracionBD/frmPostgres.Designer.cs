﻿namespace ConexionAdministracionBD
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
            this.tvPOSTGRES = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvPOSTGRES
            // 
            this.tvPOSTGRES.Location = new System.Drawing.Point(0, 0);
            this.tvPOSTGRES.Name = "tvPOSTGRES";
            this.tvPOSTGRES.Size = new System.Drawing.Size(257, 333);
            this.tvPOSTGRES.TabIndex = 0;
            this.tvPOSTGRES.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvPOSTGRES_AfterSelect);
            // 
            // frmPostgres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 394);
            this.Controls.Add(this.tvPOSTGRES);
            this.Name = "frmPostgres";
            this.Text = "frmPostgres";
            this.Load += new System.EventHandler(this.frmPostgres_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPOSTGRES;
    }
}