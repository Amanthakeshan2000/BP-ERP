namespace BPERP
{
    partial class Doctor_Register_new
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.doctorUserControl11 = new BPERP.DoctorUserControl1();
            this.SuspendLayout();
            // 
            // doctorUserControl11
            // 
            this.doctorUserControl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.doctorUserControl11.Location = new System.Drawing.Point(0, -3);
            this.doctorUserControl11.Name = "doctorUserControl11";
            this.doctorUserControl11.Size = new System.Drawing.Size(1263, 819);
            this.doctorUserControl11.TabIndex = 0;
            this.doctorUserControl11.Load += new System.EventHandler(this.doctorUserControl11_Load);
            // 
            // Doctor_Register_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doctorUserControl11);
            this.Name = "Doctor_Register_new";
            this.Size = new System.Drawing.Size(1263, 696);
            this.ResumeLayout(false);

        }

        #endregion

        private DoctorUserControl1 doctorUserControl11;
    }
}
