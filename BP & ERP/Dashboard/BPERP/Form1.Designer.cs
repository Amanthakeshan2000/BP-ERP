namespace BPERP
{
    partial class Form1
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
            this.groupBoxForm1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkreset = new System.Windows.Forms.LinkLabel();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.txtpsw = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.labelPsw = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.form1Select = new System.Windows.Forms.ComboBox();
            this.labelForm1 = new System.Windows.Forms.Label();
            this.pictureBoxForm1 = new System.Windows.Forms.PictureBox();
            this.logoForm1 = new System.Windows.Forms.PictureBox();
            this.doctor_Register_new1 = new BPERP.Doctor_Register_new();
            this.groupBoxForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoForm1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxForm1
            // 
            this.groupBoxForm1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxForm1.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxForm1.Controls.Add(this.linkLabel1);
            this.groupBoxForm1.Controls.Add(this.linkreset);
            this.groupBoxForm1.Controls.Add(this.bttnLogin);
            this.groupBoxForm1.Controls.Add(this.txtpsw);
            this.groupBoxForm1.Controls.Add(this.txtUname);
            this.groupBoxForm1.Controls.Add(this.labelPsw);
            this.groupBoxForm1.Controls.Add(this.labelName);
            this.groupBoxForm1.Controls.Add(this.form1Select);
            this.groupBoxForm1.Controls.Add(this.labelForm1);
            this.groupBoxForm1.Controls.Add(this.pictureBoxForm1);
            this.groupBoxForm1.Controls.Add(this.logoForm1);
            this.groupBoxForm1.Location = new System.Drawing.Point(590, -2);
            this.groupBoxForm1.Name = "groupBoxForm1";
            this.groupBoxForm1.Size = new System.Drawing.Size(532, 809);
            this.groupBoxForm1.TabIndex = 1;
            this.groupBoxForm1.TabStop = false;
            this.groupBoxForm1.Text = "Clinic Management System";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(151, 611);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(195, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create a Doctor Account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_3);
            // 
            // linkreset
            // 
            this.linkreset.AutoSize = true;
            this.linkreset.LinkColor = System.Drawing.Color.White;
            this.linkreset.Location = new System.Drawing.Point(226, 575);
            this.linkreset.Name = "linkreset";
            this.linkreset.Size = new System.Drawing.Size(39, 16);
            this.linkreset.TabIndex = 10;
            this.linkreset.TabStop = true;
            this.linkreset.Text = "Clear";
            this.linkreset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkreset_LinkClicked);
            // 
            // bttnLogin
            // 
            this.bttnLogin.BackColor = System.Drawing.Color.White;
            this.bttnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLogin.Location = new System.Drawing.Point(179, 521);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(141, 38);
            this.bttnLogin.TabIndex = 9;
            this.bttnLogin.Text = "Login";
            this.bttnLogin.UseVisualStyleBackColor = false;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // txtpsw
            // 
            this.txtpsw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtpsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpsw.Location = new System.Drawing.Point(63, 452);
            this.txtpsw.Name = "txtpsw";
            this.txtpsw.Size = new System.Drawing.Size(363, 30);
            this.txtpsw.TabIndex = 8;
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUname.Location = new System.Drawing.Point(64, 367);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(363, 30);
            this.txtUname.TabIndex = 7;
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // labelPsw
            // 
            this.labelPsw.AutoSize = true;
            this.labelPsw.ForeColor = System.Drawing.Color.White;
            this.labelPsw.Location = new System.Drawing.Point(61, 427);
            this.labelPsw.Name = "labelPsw";
            this.labelPsw.Size = new System.Drawing.Size(67, 16);
            this.labelPsw.TabIndex = 6;
            this.labelPsw.Text = "Password";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(61, 342);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "User Name ";
            // 
            // form1Select
            // 
            this.form1Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.form1Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1Select.FormattingEnabled = true;
            this.form1Select.Items.AddRange(new object[] {
            "Admin",
            "Doctor",
            "Receptionist"});
            this.form1Select.Location = new System.Drawing.Point(153, 249);
            this.form1Select.Name = "form1Select";
            this.form1Select.Size = new System.Drawing.Size(209, 33);
            this.form1Select.TabIndex = 4;
            // 
            // labelForm1
            // 
            this.labelForm1.AutoSize = true;
            this.labelForm1.BackColor = System.Drawing.Color.White;
            this.labelForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm1.Location = new System.Drawing.Point(68, 21);
            this.labelForm1.Name = "labelForm1";
            this.labelForm1.Size = new System.Drawing.Size(359, 32);
            this.labelForm1.TabIndex = 3;
            this.labelForm1.Text = "Clinic Management System";
            // 
            // pictureBoxForm1
            // 
            this.pictureBoxForm1.BackColor = System.Drawing.Color.White;
            this.pictureBoxForm1.Location = new System.Drawing.Point(0, -2);
            this.pictureBoxForm1.Name = "pictureBoxForm1";
            this.pictureBoxForm1.Size = new System.Drawing.Size(532, 80);
            this.pictureBoxForm1.TabIndex = 2;
            this.pictureBoxForm1.TabStop = false;
            // 
            // logoForm1
            // 
            this.logoForm1.BackgroundImage = global::BPERP.Properties.Resources.logo2_01_1;
            this.logoForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoForm1.Location = new System.Drawing.Point(122, 116);
            this.logoForm1.Name = "logoForm1";
            this.logoForm1.Size = new System.Drawing.Size(267, 89);
            this.logoForm1.TabIndex = 1;
            this.logoForm1.TabStop = false;
            // 
            // doctor_Register_new1
            // 
            this.doctor_Register_new1.Location = new System.Drawing.Point(-64, -14);
            this.doctor_Register_new1.Name = "doctor_Register_new1";
            this.doctor_Register_new1.Size = new System.Drawing.Size(1186, 839);
            this.doctor_Register_new1.TabIndex = 2;
            this.doctor_Register_new1.Visible = false;
            this.doctor_Register_new1.Load += new System.EventHandler(this.doctor_Register_new1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BPERP.Properties.Resources.concentrated_doctor_working_with_virtual_screen_1__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 793);
            this.Controls.Add(this.doctor_Register_new1);
            this.Controls.Add(this.groupBoxForm1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxForm1.ResumeLayout(false);
            this.groupBoxForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoForm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBoxForm1;
        private System.Windows.Forms.LinkLabel linkreset;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.TextBox txtpsw;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Label labelPsw;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox form1Select;
        private System.Windows.Forms.Label labelForm1;
        private System.Windows.Forms.PictureBox pictureBoxForm1;
        private System.Windows.Forms.PictureBox logoForm1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Doctor_Register_new doctor_Register_new1;
    }
}

