namespace ConexionAdministracionBD
{
    partial class AdminSesiones
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHOST = new System.Windows.Forms.Label();
            this.lblUSUARIO = new System.Windows.Forms.Label();
            this.lblPASSWORD = new System.Windows.Forms.Label();
            this.lblPUERTO = new System.Windows.Forms.Label();
            this.txtHOST = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtROOT = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.duPUERTO = new System.Windows.Forms.DomainUpDown();
            this.btnCONECTAR = new System.Windows.Forms.Button();
            this.lblBASEDATOS = new System.Windows.Forms.Label();
            this.btnBROWSER = new System.Windows.Forms.Button();
            this.btnPRUEBA = new System.Windows.Forms.Button();
            this.cmbPRUEBA = new System.Windows.Forms.ComboBox();
            this.lblARCHIVO = new System.Windows.Forms.Label();
            this.txtARCHIVO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de servidor:";
            // 
            // lblHOST
            // 
            this.lblHOST.AutoSize = true;
            this.lblHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOST.Location = new System.Drawing.Point(25, 250);
            this.lblHOST.Name = "lblHOST";
            this.lblHOST.Size = new System.Drawing.Size(186, 24);
            this.lblHOST.TabIndex = 2;
            this.lblHOST.Text = "Nombre del host / IP:";
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSUARIO.Location = new System.Drawing.Point(25, 118);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(79, 24);
            this.lblUSUARIO.TabIndex = 3;
            this.lblUSUARIO.Text = "Usuario:";
            // 
            // lblPASSWORD
            // 
            this.lblPASSWORD.AutoSize = true;
            this.lblPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASSWORD.Location = new System.Drawing.Point(25, 162);
            this.lblPASSWORD.Name = "lblPASSWORD";
            this.lblPASSWORD.Size = new System.Drawing.Size(111, 24);
            this.lblPASSWORD.TabIndex = 4;
            this.lblPASSWORD.Text = "Contraseña:";
            // 
            // lblPUERTO
            // 
            this.lblPUERTO.AutoSize = true;
            this.lblPUERTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUERTO.Location = new System.Drawing.Point(27, 206);
            this.lblPUERTO.Name = "lblPUERTO";
            this.lblPUERTO.Size = new System.Drawing.Size(70, 24);
            this.lblPUERTO.TabIndex = 5;
            this.lblPUERTO.Text = "Puerto:";
            // 
            // txtHOST
            // 
            this.txtHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOST.Location = new System.Drawing.Point(217, 248);
            this.txtHOST.Name = "txtHOST";
            this.txtHOST.Size = new System.Drawing.Size(307, 26);
            this.txtHOST.TabIndex = 6;
            this.txtHOST.Text = "127.0.0.1";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MySQL(TCP/ IP)",
            "Postgres",
            "SQL Server(TCP/IP)",
            "SQLite",
            "MongoDB",
            "RavenDB"});
            this.comboBox1.Location = new System.Drawing.Point(217, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtROOT
            // 
            this.txtROOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtROOT.Location = new System.Drawing.Point(217, 116);
            this.txtROOT.Name = "txtROOT";
            this.txtROOT.Size = new System.Drawing.Size(307, 26);
            this.txtROOT.TabIndex = 8;
            this.txtROOT.Text = "root";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Location = new System.Drawing.Point(217, 160);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(307, 26);
            this.txtPASSWORD.TabIndex = 9;
            this.txtPASSWORD.UseSystemPasswordChar = true;
            // 
            // duPUERTO
            // 
            this.duPUERTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duPUERTO.Location = new System.Drawing.Point(217, 204);
            this.duPUERTO.Name = "duPUERTO";
            this.duPUERTO.Size = new System.Drawing.Size(155, 26);
            this.duPUERTO.TabIndex = 10;
            this.duPUERTO.Text = "3306";
            // 
            // btnCONECTAR
            // 
            this.btnCONECTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONECTAR.Location = new System.Drawing.Point(324, 361);
            this.btnCONECTAR.Name = "btnCONECTAR";
            this.btnCONECTAR.Size = new System.Drawing.Size(158, 38);
            this.btnCONECTAR.TabIndex = 11;
            this.btnCONECTAR.Text = "Conectar";
            this.btnCONECTAR.UseVisualStyleBackColor = true;
            this.btnCONECTAR.Click += new System.EventHandler(this.btnCONECTAR_Click);
            // 
            // lblBASEDATOS
            // 
            this.lblBASEDATOS.AutoSize = true;
            this.lblBASEDATOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBASEDATOS.Location = new System.Drawing.Point(25, 295);
            this.lblBASEDATOS.Name = "lblBASEDATOS";
            this.lblBASEDATOS.Size = new System.Drawing.Size(134, 24);
            this.lblBASEDATOS.TabIndex = 12;
            this.lblBASEDATOS.Text = "Base de datos:";
            // 
            // btnBROWSER
            // 
            this.btnBROWSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBROWSER.Location = new System.Drawing.Point(440, 71);
            this.btnBROWSER.Name = "btnBROWSER";
            this.btnBROWSER.Size = new System.Drawing.Size(84, 26);
            this.btnBROWSER.TabIndex = 14;
            this.btnBROWSER.Text = "Browser";
            this.btnBROWSER.UseVisualStyleBackColor = true;
            this.btnBROWSER.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPRUEBA
            // 
            this.btnPRUEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRUEBA.Location = new System.Drawing.Point(69, 361);
            this.btnPRUEBA.Name = "btnPRUEBA";
            this.btnPRUEBA.Size = new System.Drawing.Size(158, 38);
            this.btnPRUEBA.TabIndex = 15;
            this.btnPRUEBA.Text = "PRUEBA";
            this.btnPRUEBA.UseVisualStyleBackColor = true;
            this.btnPRUEBA.Click += new System.EventHandler(this.btnPRUEBA_Click);
            // 
            // cmbPRUEBA
            // 
            this.cmbPRUEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPRUEBA.FormattingEnabled = true;
            this.cmbPRUEBA.Location = new System.Drawing.Point(217, 291);
            this.cmbPRUEBA.Name = "cmbPRUEBA";
            this.cmbPRUEBA.Size = new System.Drawing.Size(218, 28);
            this.cmbPRUEBA.TabIndex = 16;
            // 
            // lblARCHIVO
            // 
            this.lblARCHIVO.AutoSize = true;
            this.lblARCHIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARCHIVO.Location = new System.Drawing.Point(27, 73);
            this.lblARCHIVO.Name = "lblARCHIVO";
            this.lblARCHIVO.Size = new System.Drawing.Size(79, 24);
            this.lblARCHIVO.TabIndex = 17;
            this.lblARCHIVO.Text = "Archivo:";
            // 
            // txtARCHIVO
            // 
            this.txtARCHIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtARCHIVO.Location = new System.Drawing.Point(217, 71);
            this.txtARCHIVO.Name = "txtARCHIVO";
            this.txtARCHIVO.Size = new System.Drawing.Size(217, 26);
            this.txtARCHIVO.TabIndex = 18;
            this.txtARCHIVO.UseSystemPasswordChar = true;
            // 
            // AdminSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 411);
            this.Controls.Add(this.txtARCHIVO);
            this.Controls.Add(this.lblARCHIVO);
            this.Controls.Add(this.cmbPRUEBA);
            this.Controls.Add(this.btnPRUEBA);
            this.Controls.Add(this.btnBROWSER);
            this.Controls.Add(this.lblBASEDATOS);
            this.Controls.Add(this.btnCONECTAR);
            this.Controls.Add(this.duPUERTO);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtROOT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtHOST);
            this.Controls.Add(this.lblPUERTO);
            this.Controls.Add(this.lblPASSWORD);
            this.Controls.Add(this.lblUSUARIO);
            this.Controls.Add(this.lblHOST);
            this.Controls.Add(this.label1);
            this.Name = "AdminSesiones";
            this.Text = "Administrador de sesiones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHOST;
        private System.Windows.Forms.Label lblUSUARIO;
        private System.Windows.Forms.Label lblPASSWORD;
        private System.Windows.Forms.Label lblPUERTO;
        private System.Windows.Forms.TextBox txtHOST;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtROOT;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.DomainUpDown duPUERTO;
        private System.Windows.Forms.Button btnCONECTAR;
        private System.Windows.Forms.Label lblBASEDATOS;
        private System.Windows.Forms.Button btnBROWSER;
        private System.Windows.Forms.Button btnPRUEBA;
        private System.Windows.Forms.ComboBox cmbPRUEBA;
        private System.Windows.Forms.Label lblARCHIVO;
        private System.Windows.Forms.TextBox txtARCHIVO;
    }
}