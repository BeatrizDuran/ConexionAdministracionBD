﻿namespace ConexionAdministracionBD
{
    partial class frmMySql
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
            this.tvMysql = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tvMysql
            // 
            this.tvMysql.Location = new System.Drawing.Point(0, 0);
            this.tvMysql.Name = "tvMysql";
            this.tvMysql.Size = new System.Drawing.Size(195, 340);
            this.tvMysql.TabIndex = 3;
            this.tvMysql.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBASEDATOS_AfterSelect);
            // 
            // frmMySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 344);
            this.Controls.Add(this.tvMysql);
            this.Name = "frmMySql";
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.frmMySql_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tvMysql;
    }
}