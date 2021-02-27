namespace PBL2___1
{
    partial class FormCreateWallet
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
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Lb0 = new System.Windows.Forms.Label();
            this.Tbx2 = new System.Windows.Forms.TextBox();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Tbx1 = new System.Windows.Forms.TextBox();
            this.Lb1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrBx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrBx1
            // 
            this.GrBx1.Controls.Add(this.Btn3);
            this.GrBx1.Controls.Add(this.Btn1);
            this.GrBx1.Controls.Add(this.Btn2);
            this.GrBx1.Controls.Add(this.Lb0);
            this.GrBx1.Controls.Add(this.Tbx2);
            this.GrBx1.Controls.Add(this.Lb2);
            this.GrBx1.Controls.Add(this.Tbx1);
            this.GrBx1.Controls.Add(this.Lb1);
            this.GrBx1.Location = new System.Drawing.Point(38, 21);
            this.GrBx1.Name = "GrBx1";
            this.GrBx1.Size = new System.Drawing.Size(736, 417);
            this.GrBx1.TabIndex = 0;
            this.GrBx1.TabStop = false;
            this.GrBx1.UseWaitCursor = true;
            // 
            // Btn3
            // 
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.Location = new System.Drawing.Point(572, 263);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(100, 42);
            this.Btn3.TabIndex = 5;
            this.Btn3.Text = "Thoát";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.UseWaitCursor = true;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(312, 263);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(100, 42);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "Kiểm tra";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.UseWaitCursor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.Location = new System.Drawing.Point(441, 263);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(100, 42);
            this.Btn2.TabIndex = 4;
            this.Btn2.Text = "Tạo ví";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.UseWaitCursor = true;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Lb0
            // 
            this.Lb0.AutoSize = true;
            this.Lb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb0.Location = new System.Drawing.Point(183, 38);
            this.Lb0.Name = "Lb0";
            this.Lb0.Size = new System.Drawing.Size(395, 32);
            this.Lb0.TabIndex = 0;
            this.Lb0.Text = "Nhập thông tin để tạo ví mới";
            this.Lb0.UseWaitCursor = true;
            // 
            // Tbx2
            // 
            this.Tbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx2.Location = new System.Drawing.Point(298, 187);
            this.Tbx2.Name = "Tbx2";
            this.Tbx2.Size = new System.Drawing.Size(374, 34);
            this.Tbx2.TabIndex = 2;
            this.Tbx2.UseWaitCursor = true;
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(15, 184);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(244, 29);
            this.Lb2.TabIndex = 0;
            this.Lb2.Text = "Số tiền trong ví (VND)";
            this.Lb2.UseWaitCursor = true;
            // 
            // Tbx1
            // 
            this.Tbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx1.Location = new System.Drawing.Point(298, 129);
            this.Tbx1.Name = "Tbx1";
            this.Tbx1.Size = new System.Drawing.Size(374, 34);
            this.Tbx1.TabIndex = 1;
            this.Tbx1.UseWaitCursor = true;
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(15, 126);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(125, 29);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Tên ví mới";
            this.Lb1.UseWaitCursor = true;
            // 
            // FormCreateWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrBx1);
            this.Name = "FormCreateWallet";
            this.Text = "Hello User!";
            this.GrBx1.ResumeLayout(false);
            this.GrBx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrBx1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Label Lb0;
        private System.Windows.Forms.TextBox Tbx2;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.TextBox Tbx1;
        private System.Windows.Forms.Label Lb1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Btn3;
    }
}