using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PBL2___1.DAO;
using PBL2___1.DTO;

namespace PBL2___1
{
    public partial class FormUser : Form
    {
        private int ListStatus = 0;
        public FormUser()
        {
            InitializeComponent();
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void accountInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormUpdateAccountInformation fAcc = new FormUpdateAccountInformation();
            fAcc.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ListStatus != 0)
            {
                if (Cbb1.SelectedValue != null)
                {
                    LoadItemDetails((Cbb1.SelectedValue.ToString()).Trim(' '));
                }   
            }
        }
        void LoadWalletList()
        {
            string ItemQuery = "'" + AccountDAO.Instance.GetUserID().Trim(' ') + "'";
            string query = "SELECT Tittle,Wallet_ID FROM dbo.Wallet JOIN dbo.Users ON Wallet.UserID = Users.UserID WHERE Users.UserID = " + ItemQuery;
            DataProvider provider = new DataProvider();
            Cbb1.DataSource = provider.ExecuteQuery(query);
            Cbb1.DisplayMember = "Tittle";
            Cbb1.ValueMember = "Wallet_ID";
        }
        void LoadWalletListInfo()
        {
            //string query = "SELECT * FROM dbo.Wallet WHERE UserID = '" + AccountDAO.Instance.GetUserID() + "'";
            //string query = $"USP_SUMWltMoney4 @WltID = N'{AccountDAO.Instance.GetUserID()}'";
            //DataProvider.Instance.ExecuteNonQuery(query);
            string query = $"USP_LoadWalletListInfo @userID = N'{AccountDAO.Instance.GetUserID()}'";
            DataProvider provider = new DataProvider();
            Dtgv1.DataSource = provider.ExecuteQuery(query);
        }
        void LoadDebitbookList()
        {
            string ItemQuery = "'" + AccountDAO.Instance.GetUserID().Trim(' ') + "'";
            string query = "SELECT Tittle,Debitbook_ID FROM dbo.Debitbook JOIN dbo.Users ON Debitbook.UserID = Users.UserID WHERE Users.UserID = " + ItemQuery;
            DataProvider provider = new DataProvider();
            Cbb1.DataSource = provider.ExecuteQuery(query);
            Cbb1.DisplayMember = "Tittle";
            Cbb1.ValueMember = "Debitbook_ID";
        }
        void LoadDebitbookListInfo()
        {
            //string query = "SELECT * FROM dbo.Debitbook WHERE UserID = '" + AccountDAO.Instance.GetUserID() + "'";
            string query = $"USP_LoadDbbListInfo @userID = N'{AccountDAO.Instance.GetUserID()}'";
            DataProvider provider = new DataProvider();
            Dtgv1.DataSource = provider.ExecuteQuery(query);
        }
        void LoadItemDetails(string ItemSelected)
        {
            if (ListStatus == 1)
            {
                //string query = $"USP_SUMWltMoney5 @WltID = N'{ItemSelected}'";
                //DataProvider.Instance.ExecuteNonQuery(query);
                string query = $"USP_ViewWalletDetails1 @WalletID = {ItemSelected}";
                DataProvider provider = new DataProvider();
                Dtgv1.DataSource = provider.ExecuteQuery(query);
            }
            else if (ListStatus == 2)
            {
                //string query = $"USP_SumDbbMoney @DbbID = {ItemSelected}";
                //DataProvider.Instance.ExecuteNonQuery(query);
                string query = $"USP_ViewDbbDetails1 @DbbID = {ItemSelected}";
                DataProvider provider = new DataProvider();
                Dtgv1.DataSource = provider.ExecuteQuery(query);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (ListStatus == 1)
            {
                LoadWalletListInfo();
            }
            else if (ListStatus == 2)
            {
                LoadDebitbookListInfo();
            }
            else
            {
            }
        }
        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadWalletList();
            ListStatus = 1;
        }
        private void viewDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadDebitbookList();
            ListStatus = 2;
        }
        private void xemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewAccountInfo f = new FormViewAccountInfo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateAccountInformation f = new FormUpdateAccountInformation();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void createANewWalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateWallet f = new FormCreateWallet();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void createANewDebitBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateDebitbook f = new FormCreateDebitbook();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Cbb1.SelectedValue != null)
            {
                if (ListStatus == 1)
                {
                    FormUpdateWallet f = new FormUpdateWallet((Cbb1.SelectedValue.ToString()).Trim(' '));
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    LoadWalletList();
                }
                else if (ListStatus == 2)
                {
                    FormUpdateDebitbook f = new FormUpdateDebitbook((Cbb1.SelectedValue.ToString()).Trim(' '));
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    LoadDebitbookList();
                }
                else
                {

                }
            }
        }
        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (Cbb1.SelectedValue != null)
            {
                if (ListStatus == 1)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ví này không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        WalletDAO.Instance.DeleteWallet((Cbb1.SelectedValue.ToString()).Trim(' '));
                        MessageBox.Show("Xóa ví thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadWalletList();
                    }
                }
                else if (ListStatus == 2)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa sổ nợ này không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        DebitbookDAO.Instance.DeleteDebitbook((Cbb1.SelectedValue.ToString()).Trim(' '));
                        MessageBox.Show("Xóa sổ vay thành công!", "Thông báo", MessageBoxButtons.OK);
                        LoadDebitbookList();
                    }

                }
            }
        }
        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?","Thông báo",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (AccountDAO.Instance.DeleteAccount(AccountDAO.Instance.GetUserID()) == true)
                {
                    MessageBox.Show("Đã xóa tài khoản!", "Thông báo", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics f = new FormStatistics(AccountDAO.Instance.GetUserID());
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
