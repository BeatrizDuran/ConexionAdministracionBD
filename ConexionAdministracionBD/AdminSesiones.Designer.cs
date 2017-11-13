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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de servidor:";
            // 
            // lblHOST
            // 
            this.lblHOST.AutoSize = true;
            this.lblHOST.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHOST.Location = new System.Drawing.Point(25, 250);
            this.lblHOST.Name = "lblHOST";
            this.lblHOST.Size = new System.Drawing.Size(199, 22);
            this.lblHOST.TabIndex = 2;
            this.lblHOST.Text = "Nombre del host / IP:";
            // 
            // lblUSUARIO
            // 
            this.lblUSUARIO.AutoSize = true;
            this.lblUSUARIO.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSUARIO.Location = new System.Drawing.Point(25, 118);
            this.lblUSUARIO.Name = "lblUSUARIO";
            this.lblUSUARIO.Size = new System.Drawing.Size(80, 22);
            this.lblUSUARIO.TabIndex = 3;
            this.lblUSUARIO.Text = "Usuario:";
            // 
            // lblPASSWORD
            // 
            this.lblPASSWORD.AutoSize = true;
            this.lblPASSWORD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASSWORD.Location = new System.Drawing.Point(25, 162);
            this.lblPASSWORD.Name = "lblPASSWORD";
            this.lblPASSWORD.Size = new System.Drawing.Size(124, 22);
            this.lblPASSWORD.TabIndex = 4;
            this.lblPASSWORD.Text = "Contraseña:";
            // 
            // lblPUERTO
            // 
            this.lblPUERTO.AutoSize = true;
            this.lblPUERTO.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUERTO.Location = new System.Drawing.Point(27, 206);
            this.lblPUERTO.Name = "lblPUERTO";
            this.lblPUERTO.Size = new System.Drawing.Size(75, 22);
            this.lblPUERTO.TabIndex = 5;
            this.lblPUERTO.Text = "Puerto:";
            // 
            // txtHOST
            // 
            this.txtHOST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOST.Location = new System.Drawing.Point(230, 246);
            this.txtHOST.Name = "txtHOST";
            this.txtHOST.Size = new System.Drawing.Size(307, 26);
            this.txtHOST.TabIndex = 6;
            this.txtHOST.Text = "127.0.0.1";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MySQL(TCP/ IP)",
            "Postgres",
            "SQL Server(TCP/IP)",
            "SQLite",
            "MongoDB",
            "RavenDB"});
            this.comboBox1.Location = new System.Drawing.Point(230, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtROOT
            // 
            this.txtROOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtROOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtROOT.Location = new System.Drawing.Point(230, 118);
            this.txtROOT.Name = "txtROOT";
            this.txtROOT.Size = new System.Drawing.Size(307, 26);
            this.txtROOT.TabIndex = 8;
            this.txtROOT.Text = "root";
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASSWORD.Location = new System.Drawing.Point(230, 162);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(307, 26);
            this.txtPASSWORD.TabIndex = 9;
            this.txtPASSWORD.UseSystemPasswordChar = true;
            // 
            // duPUERTO
            // 
            this.duPUERTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duPUERTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duPUERTO.Location = new System.Drawing.Point(230, 206);
            this.duPUERTO.Name = "duPUERTO";
            this.duPUERTO.Size = new System.Drawing.Size(155, 26);
            this.duPUERTO.TabIndex = 10;
            this.duPUERTO.Text = "3306";
            // 
            // btnCONECTAR
            // 
            this.btnCONECTAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCONECTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONECTAR.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONECTAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCONECTAR.Location = new System.Drawing.Point(373, 17);
            this.btnCONECTAR.Name = "btnCONECTAR";
            this.btnCONECTAR.Size = new System.Drawing.Size(164, 49);
            this.btnCONECTAR.TabIndex = 11;
            this.btnCONECTAR.Text = "Conectar";
            this.btnCONECTAR.UseVisualStyleBackColor = false;
            this.btnCONECTAR.Click += new System.EventHandler(this.btnCONECTAR_Click);
            // 
            // lblBASEDATOS
            // 
            this.lblBASEDATOS.AutoSize = true;
            this.lblBASEDATOS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBASEDATOS.Location = new System.Drawing.Point(25, 295);
            this.lblBASEDATOS.Name = "lblBASEDATOS";
            this.lblBASEDATOS.Size = new System.Drawing.Size(145, 22);
            this.lblBASEDATOS.TabIndex = 12;
            this.lblBASEDATOS.Text = "Base de datos:";
            // 
            // btnBROWSER
            // 
            this.btnBROWSER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBROWSER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBROWSER.Location = new System.Drawing.Point(453, 71);
            this.btnBROWSER.Name = "btnBROWSER";
            this.btnBROWSER.Size = new System.Drawing.Size(84, 26);
            this.btnBROWSER.TabIndex = 14;
            this.btnBROWSER.Text = "Browser";
            this.btnBROWSER.UseVisualStyleBackColor = true;
            this.btnBROWSER.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPRUEBA
            // 
            this.btnPRUEBA.BackColor = System.Drawing.Color.White;
            this.btnPRUEBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPRUEBA.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRUEBA.Location = new System.Drawing.Point(133, 17);
            this.btnPRUEBA.Name = "btnPRUEBA";
            this.btnPRUEBA.Size = new System.Drawing.Size(223, 49);
            this.btnPRUEBA.TabIndex = 15;
            this.btnPRUEBA.Text = "Prueba de conexión";
            this.btnPRUEBA.UseVisualStyleBackColor = false;
            this.btnPRUEBA.Click += new System.EventHandler(this.btnPRUEBA_Click);
            // 
            // cmbPRUEBA
            // 
            this.cmbPRUEBA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPRUEBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPRUEBA.FormattingEnabled = true;
            this.cmbPRUEBA.Location = new System.Drawing.Point(230, 291);
            this.cmbPRUEBA.Name = "cmbPRUEBA";
            this.cmbPRUEBA.Size = new System.Drawing.Size(218, 28);
            this.cmbPRUEBA.TabIndex = 16;
            // 
            // lblARCHIVO
            // 
            this.lblARCHIVO.AutoSize = true;
            this.lblARCHIVO.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblARCHIVO.Location = new System.Drawing.Point(27, 73);
            this.lblARCHIVO.Name = "lblARCHIVO";
            this.lblARCHIVO.Size = new System.Drawing.Size(88, 22);
            this.lblARCHIVO.TabIndex = 17;
            this.lblARCHIVO.Text = "Archivo:";
            // 
            // txtARCHIVO
            // 
            this.txtARCHIVO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtARCHIVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtARCHIVO.Location = new System.Drawing.Point(230, 72);
            this.txtARCHIVO.Name = "txtARCHIVO";
            this.txtARCHIVO.Size = new System.Drawing.Size(217, 26);
            this.txtARCHIVO.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 49);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPRUEBA);
            this.panel1.Controls.Add(this.btnCONECTAR);
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 73);
            this.panel1.TabIndex = 20;
            // 
            // AdminSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 416);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtARCHIVO);
            this.Controls.Add(this.lblARCHIVO);
            this.Controls.Add(this.cmbPRUEBA);
            this.Controls.Add(this.btnBROWSER);
            this.Controls.Add(this.lblBASEDATOS);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}