
namespace PBL2___1
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.C1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lb0 = new System.Windows.Forms.Label();
            this.Cbb1 = new System.Windows.Forms.ComboBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Lb1 = new System.Windows.Forms.Label();
            this.Cbb2 = new System.Windows.Forms.ComboBox();
            this.Lb2 = new System.Windows.Forms.Label();
            this.Lb3 = new System.Windows.Forms.Label();
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.Lb5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbx1 = new System.Windows.Forms.TextBox();
            this.Tbx2 = new System.Windows.Forms.TextBox();
            this.Tbx3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.C1)).BeginInit();
            this.SuspendLayout();
            // 
            // C1
            // 
            chartArea2.Name = "ChartArea1";
            this.C1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.C1.Legends.Add(legend2);
            this.C1.Location = new System.Drawing.Point(692, 23);
            this.C1.Name = "C1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.C1.Series.Add(series2);
            this.C1.Size = new System.Drawing.Size(625, 566);
            this.C1.TabIndex = 0;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // Lb0
            // 
            this.Lb0.AutoSize = true;
            this.Lb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb0.Location = new System.Drawing.Point(48, 23);
            this.Lb0.Name = "Lb0";
            this.Lb0.Size = new System.Drawing.Size(93, 29);
            this.Lb0.TabIndex = 0;
            this.Lb0.Text = "Chọn ví";
            // 
            // Cbb1
            // 
            this.Cbb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb1.FormattingEnabled = true;
            this.Cbb1.Location = new System.Drawing.Point(147, 23);
            this.Cbb1.Name = "Cbb1";
            this.Cbb1.Size = new System.Drawing.Size(338, 33);
            this.Cbb1.TabIndex = 1;
            // 
            // Btn1
            // 
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(349, 259);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(136, 37);
            this.Btn1.TabIndex = 5;
            this.Btn1.Text = "Thống kê";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Lb1
            // 
            this.Lb1.AutoSize = true;
            this.Lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb1.Location = new System.Drawing.Point(56, 86);
            this.Lb1.Name = "Lb1";
            this.Lb1.Size = new System.Drawing.Size(85, 29);
            this.Lb1.TabIndex = 0;
            this.Lb1.Text = "Nguồn";
            // 
            // Cbb2
            // 
            this.Cbb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb2.FormattingEnabled = true;
            this.Cbb2.Items.AddRange(new object[] {
            "Thu vào",
            "Chi ra"});
            this.Cbb2.Location = new System.Drawing.Point(147, 82);
            this.Cbb2.Name = "Cbb2";
            this.Cbb2.Size = new System.Drawing.Size(338, 33);
            this.Cbb2.TabIndex = 2;
            this.Cbb2.SelectedIndexChanged += new System.EventHandler(this.Cbb2_SelectedIndexChanged);
            // 
            // Lb2
            // 
            this.Lb2.AutoSize = true;
            this.Lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2.Location = new System.Drawing.Point(99, 143);
            this.Lb2.Name = "Lb2";
            this.Lb2.Size = new System.Drawing.Size(42, 29);
            this.Lb2.TabIndex = 0;
            this.Lb2.Text = "Từ";
            // 
            // Lb3
            // 
            this.Lb3.AutoSize = true;
            this.Lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb3.Location = new System.Drawing.Point(84, 201);
            this.Lb3.Name = "Lb3";
            this.Lb3.Size = new System.Drawing.Size(57, 29);
            this.Lb3.TabIndex = 0;
            this.Lb3.Text = "Đến";
            // 
            // DTP1
            // 
            this.DTP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Location = new System.Drawing.Point(147, 143);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(338, 30);
            this.DTP1.TabIndex = 3;
            // 
            // DTP2
            // 
            this.DTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP2.Location = new System.Drawing.Point(147, 201);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(338, 30);
            this.DTP2.TabIndex = 4;
            // 
            // Lb5
            // 
            this.Lb5.AutoSize = true;
            this.Lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb5.Location = new System.Drawing.Point(27, 349);
            this.Lb5.Name = "Lb5";
            this.Lb5.Size = new System.Drawing.Size(152, 25);
            this.Lb5.TabIndex = 0;
            this.Lb5.Text = "Số tiền lớn nhất ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mục đích chi tiêu / Nguồn thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày giao dịch";
            // 
            // Tbx1
            // 
            this.Tbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx1.Location = new System.Drawing.Point(320, 349);
            this.Tbx1.Name = "Tbx1";
            this.Tbx1.ReadOnly = true;
            this.Tbx1.Size = new System.Drawing.Size(295, 30);
            this.Tbx1.TabIndex = 0;
            // 
            // Tbx2
            // 
            this.Tbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx2.Location = new System.Drawing.Point(320, 408);
            this.Tbx2.Name = "Tbx2";
            this.Tbx2.ReadOnly = true;
            this.Tbx2.Size = new System.Drawing.Size(295, 30);
            this.Tbx2.TabIndex = 0;
            // 
            // Tbx3
            // 
            this.Tbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx3.Location = new System.Drawing.Point(320, 466);
            this.Tbx3.Name = "Tbx3";
            this.Tbx3.ReadOnly = true;
            this.Tbx3.Size = new System.Drawing.Size(295, 30);
            this.Tbx3.TabIndex = 0;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 601);
            this.Controls.Add(this.Tbx3);
            this.Controls.Add(this.Tbx2);
            this.Controls.Add(this.Tbx1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lb5);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.Lb3);
            this.Controls.Add(this.Lb2);
            this.Controls.Add(this.Cbb2);
            this.Controls.Add(this.Lb1);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Cbb1);
            this.Controls.Add(this.Lb0);
            this.Controls.Add(this.C1);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.C1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart C1;
        private System.Windows.Forms.Label Lb0;
        private System.Windows.Forms.ComboBox Cbb1;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label Lb1;
        private System.Windows.Forms.ComboBox Cbb2;
        private System.Windows.Forms.Label Lb2;
        private System.Windows.Forms.Label Lb3;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.Label Lb5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx1;
        private System.Windows.Forms.TextBox Tbx2;
        private System.Windows.Forms.TextBox Tbx3;
    }
}