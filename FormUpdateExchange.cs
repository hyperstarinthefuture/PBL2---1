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
    public partial class FormUpdateExchange : Form
    {
        private int AllowUpdateStatus = 0;
        private int ExchangeType;
        private string ExchangeID;
        private string WalletID;
        private double money;
        public FormUpdateExchange(int Type,string exchangeID, string WltID)
        {
            InitializeComponent();
            ExchangeType = Type;
            ExchangeID = exchangeID.Trim(' ');
            WalletID = WltID.Trim(' ');
            LoadData();
        }
        public void LoadData()
        {
            string query;
            if (ExchangeType == 1)
            {
                query = string.Format("SELECT * FROM Income WHERE Income_ID = N'{0}' AND Wallet_ID = N'{1}'", ExchangeID, WalletID);
            }
            else
            {
                query = string.Format("SELECT * FROM Expense WHERE Expense_ID = N'{0}' AND Wallet_ID = N'{1}'", ExchangeID, WalletID);
            }
            DataProvider dp = new DataProvider();
            DataTable dt = dp.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            Cbb1.DataSource = dt;
            if (ExchangeType == 1)
            {
                Cbb1.DisplayMember = "Source_ID";
                Cbb1.ValueMember = "Source_ID";
            }
            else
            {
                Cbb1.DisplayMember = "Reason_ID";
                Cbb1.ValueMember = "Reason_ID";
            }
            Tbx1.Text = dr.ItemArray[2].ToString().Trim(' ');
            DTP1.Value = Convert.ToDateTime(dr.ItemArray[3]);
            Tbx2.Text = dr.ItemArray[5].ToString().Trim(' ');
            money = Double.Parse(dr.ItemArray[2].ToString().Trim(' '));
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Tbx1.Text != "" && Tbx2.Text != "")
            {
                AllowUpdateStatus = 1;
                MessageBox.Show("Dữ liệu đã nhập phù hợp để cập nhật!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn đã nhập không đúng quy định, yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (AllowUpdateStatus == 1)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin giao dịch này không?","Thông báo",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (ExchangeDAO.Instance.UpdateExchange(ExchangeType,ExchangeID,int.Parse(Cbb1.SelectedValue.ToString()),Double.Parse(Tbx1.Text),money,DTP1.Value,WalletID,Tbx2.Text) == true)
                    {
                        MessageBox.Show("Cập nhật thông tin giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    this.Close();
                }    
            }
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
