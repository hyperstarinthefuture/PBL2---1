namespace PBL2___1
{
    partial class FormUser
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
            this.components = new System.ComponentModel.Container();
            this.Cbb1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewWalletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDebitBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewDebitBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dtgv1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnViewList = new System.Windows.Forms.Button();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cbb1
            // 
            this.Cbb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cbb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cbb1.FormattingEnabled = true;
            this.Cbb1.Location = new System.Drawing.Point(230, 11);
            this.Cbb1.Name = "Cbb1";
            this.Cbb1.Size = new System.Drawing.Size(240, 24);
            this.Cbb1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInformationToolStripMenuItem,
            this.manageWalletToolStripMenuItem,
            this.manageDebitBookToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInformationToolStripMenuItem1,
            this.logOutToolStripMenuItem});
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.accountInformationToolStripMenuItem.Text = "Tài khoản";
            // 
            // accountInformationToolStripMenuItem1
            // 
            this.accountInformationToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.xóaTàiKhoảnToolStripMenuItem});
            this.accountInformationToolStripMenuItem1.Name = "accountInformationToolStripMenuItem1";
            this.accountInformationToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.accountInformationToolStripMenuItem1.Text = "Thông tin tài khoản";
            this.accountInformationToolStripMenuItem1.Click += new System.EventHandler(this.accountInformationToolStripMenuItem1_Click);
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.xemToolStripMenuItem.Text = "Xem";
            this.xemToolStripMenuItem.Click += new System.EventHandler(this.xemToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản";
            this.xóaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.xóaTàiKhoảnToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.logOutToolStripMenuItem.Text = "Đăng xuất";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // manageWalletToolStripMenuItem
            // 
            this.manageWalletToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createANewWalletToolStripMenuItem,
            this.viewDetailsToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.manageWalletToolStripMenuItem.Name = "manageWalletToolStripMenuItem";
            this.manageWalletToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.manageWalletToolStripMenuItem.Text = "Quản lí ví tiền";
            // 
            // createANewWalletToolStripMenuItem
            // 
            this.createANewWalletToolStripMenuItem.Name = "createANewWalletToolStripMenuItem";
            this.createANewWalletToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.createANewWalletToolStripMenuItem.Text = "Tạo ví mới";
            this.createANewWalletToolStripMenuItem.Click += new System.EventHandler(this.createANewWalletToolStripMenuItem_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.viewDetailsToolStripMenuItem.Text = "Hiển thị ";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // manageDebitBookToolStripMenuItem
            // 
            this.manageDebitBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createANewDebitBookToolStripMenuItem,
            this.viewDetailsToolStripMenuItem1});
            this.manageDebitBookToolStripMenuItem.Name = "manageDebitBookToolStripMenuItem";
            this.manageDebitBookToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.manageDebitBookToolStripMenuItem.Text = "Quản lí sổ vay nợ";
            // 
            // createANewDebitBookToolStripMenuItem
            // 
            this.createANewDebitBookToolStripMenuItem.Name = "createANewDebitBookToolStripMenuItem";
            this.createANewDebitBookToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createANewDebitBookToolStripMenuItem.Text = "Tạo sổ vay nợ mới";
            this.createANewDebitBookToolStripMenuItem.Click += new System.EventHandler(this.createANewDebitBookToolStripMenuItem_Click);
            // 
            // viewDetailsToolStripMenuItem1
            // 
            this.viewDetailsToolStripMenuItem1.Name = "viewDetailsToolStripMenuItem1";
            this.viewDetailsToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.viewDetailsToolStripMenuItem1.Text = "Hiển thị ";
            this.viewDetailsToolStripMenuItem1.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dtgv1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 407);
            this.panel1.TabIndex = 2;
            // 
            // Dtgv1
            // 
            this.Dtgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dtgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtgv1.Location = new System.Drawing.Point(3, 52);
            this.Dtgv1.Name = "Dtgv1";
            this.Dtgv1.RowHeadersWidth = 51;
            this.Dtgv1.RowTemplate.Height = 24;
            this.Dtgv1.Size = new System.Drawing.Size(1100, 355);
            this.Dtgv1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.BtnViewList);
            this.panel2.Controls.Add(this.BtnView);
            this.panel2.Controls.Add(this.BtnDel);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Controls.Add(this.Cbb1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 46);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 17);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Chọn đối tượng cần thao tác";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnViewList
            // 
            this.BtnViewList.Location = new System.Drawing.Point(876, 6);
            this.BtnViewList.Name = "BtnViewList";
            this.BtnViewList.Size = new System.Drawing.Size(216, 37);
            this.BtnViewList.TabIndex = 5;
            this.BtnViewList.Text = "Xem danh sách thông tin";
            this.BtnViewList.UseVisualStyleBackColor = true;
            this.BtnViewList.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(741, 6);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(114, 37);
            this.BtnView.TabIndex = 4;
            this.BtnView.Text = "Xem chi tiết";
            this.BtnView.UseVisualStyleBackColor = true;
            this.BtnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Location = new System.Drawing.Point(629, 6);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(92, 37);
            this.BtnDel.TabIndex = 3;
            this.BtnDel.Text = "Xóa ";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(508, 6);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(92, 37);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Cập nhật ";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormUser";
            this.Text = "Hello User!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dtgv1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageWalletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDebitBookToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ToolStripMenuItem accountInformationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewWalletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewDebitBookToolStripMenuItem;
        private System.Windows.Forms.DataGridView Dtgv1;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnViewList;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ComboBox Cbb1;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
    }
}