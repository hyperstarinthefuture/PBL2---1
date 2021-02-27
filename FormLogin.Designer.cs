namespace PBL2___1
{
    partial class FormLogin
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
            this.GrBx1 = new System.Windows.Forms.GroupBox();
            this.Lb0 = new System.Windows.Forms.Label();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Tbx1 = new System.Windows.Forms.TextBox();
            this.Lb2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.Tbx2 = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrBx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBx1
            // 
            this.GrBx1.Controls.Add(this.Lb0);
            this.GrBx1.Controls.Add(this.Lb1);
            this.GrBx1.Controls.Add(this.Tbx1);
            this.GrBx1.Controls.Add(this.Lb2);
            this.GrBx1.Controls.Add(this.BtnExit);
            this.GrBx1.Controls.Add(this.Tbx2);
            this.GrBx1.Controls.Add(this.BtnLogin);
            this.GrBx1.Location = new System.Drawing.Point(12, 12);
            this.GrBx1.Name = "GrBx1";
            this.GrBx1.Size = new System.Drawing.Size(776, 426);
            this.GrBx1.TabIndex = 0;
            this.GrBx1.TabStop = false;
            // 
            // Lb0
            // 
            this.Lb0.AutoSize = true;
            this.Lb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb0.Location = new System.Drawing.Point(306, 33);
            this.Lb0.Name = "Lb0";
            this.Lb0.Size = new System.Drawing.Size(190, 32);
            this.Lb0.TabIndex = 0;
            this.Lb0.Text = "ĐĂNG NHẬP";
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(93, 118);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(188, 29);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Tên đăng nhập";
            // 
            // Tbx1
            // 
            this.Tbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx1.Location = new System.Drawing.Point(312, 113);
            this.Tbx1.Name = "Tbx1";
            this.Tbx1.Size = new System.Drawing.Size(291, 34);
            this.Tbx1.TabIndex = 1;
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(93, 175);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(117, 29);
            this.Lb2.TabIndex = 0;
            this.Lb2.Text = "Mật khẩu";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(516, 240);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(87, 41);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Tbx2
            // 
            this.Tbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx2.Location = new System.Drawing.Point(312, 170);
            this.Tbx2.Name = "Tbx2";
            this.Tbx2.Size = new System.Drawing.Size(291, 34);
            this.Tbx2.TabIndex = 2;
            this.Tbx2.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(371, 240);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 41);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrBx1);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.GrBx1.ResumeLayout(false);
            this.GrBx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBx1;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.TextBox Tbx1;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox Tbx2;
        private System.Windows.Forms.Button BtnLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Lb0;
    }
}

