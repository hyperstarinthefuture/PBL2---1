using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL2___1.DAO;
using PBL2___1.DTO;
namespace PBL2___1
{
    public partial class FormUpdateWallet : Form
    {
        private string AccessWalletID;
        private string ExchangeID;
        private int ExchangeType;
        private double money;
        public FormUpdateWallet(string AccessWltID)
        {
            InitializeComponent();
            AccessWalletID = AccessWltID;
            ViewWalletInfo();
            LoadData();
        }
        public void ViewWalletInfo()
        {
            string query = "SELECT * FROM dbo.Wallet WHERE Wallet_ID = '" + AccessWalletID + "'";
            DataProvider provider = new DataProvider();
            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            Tbx1.Text = dr.ItemArray[0].ToString().Trim(' ');
            Tbx2.Text = dr.ItemArray[1].ToString().Trim(' ');
        }
        public bool InsertUpdatingData()
        {
            return WalletDAO.Instance.UpdateWallet(AccessWalletID,Tbx3.Text);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Tbx3.Text != "")
            {
                if (MessageBox.Show("Bạn có muốn thay đổi tên ví không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (InsertUpdatingData() == true)
                    {
                        MessageBox.Show("Thay đổi tên ví thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi tên ví không thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                ViewWalletInfo();
                Tbx3.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên ví mới!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void LoadData()
        {
            //string query = $"USP_SUMWltMoney5 @WltID = N'{AccessWalletID}'";
            //int result = DataProvider.Instance.ExecuteNonQuery(query);
            string query = $"USP_ViewExchangeDetails @WltID = {AccessWalletID}";
            DataProvider provider = new DataProvider();
            Dtgv1.DataSource = provider.ExecuteQuery(query);
        }
        private void Dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Dtgv1.Rows[e.RowIndex];
                ExchangeID = row.Cells[0].Value.ToString();
                money = Double.Parse(row.Cells[2].Value.ToString());
                if (money >= 0)
                {
                    ExchangeType = 1;
                }
                else
                {
                    ExchangeType = 0;
                }
            }
        }
        private void Btn4_Click(object sender, EventArgs e)
        {
            FormCreateExchange f = new FormCreateExchange(AccessWalletID);
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (ExchangeID != null)
            {
                FormUpdateExchange f = new FormUpdateExchange(ExchangeType, ExchangeID, AccessWalletID);
                this.Hide();
                f.ShowDialog();
                this.Show();
                LoadData();
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (ExchangeID != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ExchangeDAO.Instance.DeleteExchange(ExchangeType, ExchangeID,money,AccessWalletID) == true)
                    {
                        MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            LoadData();
            ExchangeID = null;
        }
        private void Btn7_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
