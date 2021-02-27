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
    public partial class FormCreateExchange : Form
    {
        private string WalletID;
        private string ExchangeID;
        public FormCreateExchange(string WltID)
        {
            InitializeComponent();
            WalletID = WltID;
        }
        public bool CheckData()
        {
            if ((RBtn1.Checked == true || RBtn2.Checked == true) && Cbb1.SelectedValue != null && DTP1.Value != null && Tbx1.Text != "" && Tbx2.Text != "")
            {
                if (RBtn1.Checked == true)
                {
                    if (Double.Parse(Tbx1.Text) <= 0 )
                    {
                        return true;
                    }
                }
                else
                {
                    if (Double.Parse(Tbx1.Text) > 0 )
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm giao dịch này không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    string ch = WalletID.Substring(WalletID.Length - 1, 1);
                    if (RBtn2.Checked == true)
                    {
                        ExchangeID = ExchangeDAO.Instance.GenExchangeID(1, ch);
                        if (ExchangeDAO.Instance.InsertExchange(1, ExchangeID, int.Parse(Cbb1.SelectedValue.ToString()), Double.Parse(Tbx1.Text), DTP1.Value, WalletID, Tbx2.Text.Trim(' ')) == true)
                        {
                            MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        ExchangeID = ExchangeDAO.Instance.GenExchangeID(0, ch);
                        if (ExchangeDAO.Instance.InsertExchange(0, ExchangeID, int.Parse(Cbb1.SelectedValue.ToString()), Double.Parse(Tbx1.Text), DTP1.Value, WalletID, Tbx2.Text.Trim(' ')) == true)
                        {
                            MessageBox.Show("Thêm giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                        }
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập chưa phù hợp, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void RBtn1_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Reason";
            Cbb1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            Cbb1.DisplayMember = "ReasonType";
            Cbb1.ValueMember = "Reason_ID";
        }

        private void RBtn2_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Source";
            Cbb1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            Cbb1.DisplayMember = "SourceType";
            Cbb1.ValueMember = "Source_ID";
        }
    }
}
