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
    public partial class FormUpdateLoan : Form
    {
        private int AllowUpdateStatus = 0;
        private string AccessDebitbookID;
        private string LoanID;
        public FormUpdateLoan(string DbbID, string loanID)
        {
            InitializeComponent();
            AccessDebitbookID = DbbID;
            LoanID = loanID;
            LoadData();
        }
        public void LoadData()
        {
            string query = string.Format("SELECT * FROM Loan WHERE Loan_ID = N'{0}' AND Debitbook_ID = N'{1}'", LoanID, AccessDebitbookID);
            DataProvider dp = new DataProvider();
            DataTable dt = dp.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            Tbx1.Text = dr.ItemArray[1].ToString().Trim(' ');
            Tbx2.Text = dr.ItemArray[2].ToString().Trim(' ');
            DTP1.Value = Convert.ToDateTime(dr.ItemArray[3]);
            Tbx3.Text = dr.ItemArray[4].ToString().Trim(' ');
            DTP2.Value = Convert.ToDateTime(dr.ItemArray[5]);
            Tbx4.Text = dr.ItemArray[7].ToString().Trim(' ');
            if (dr.ItemArray[8].ToString().Trim(' ') == "1")
            {
                RBtn1.Checked = true;
            }
            else
            {
                RBtn2.Checked = true;
            }
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Tbx2.Text != "" && Tbx3.Text != "")
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
                if (RBtn1.Checked == true)
                {
                    if (LoanDAO.Instance.UpdateLoan(LoanID, Double.Parse(Tbx1.Text), Tbx2.Text, DTP1.Value, Double.Parse(Tbx3.Text), DTP2.Value, AccessDebitbookID, Tbx4.Text, 1) == true)
                    {
                        MessageBox.Show("Sửa thông tin giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (LoanDAO.Instance.UpdateLoan(LoanID, Double.Parse(Tbx1.Text), Tbx2.Text, DTP1.Value, Double.Parse(Tbx3.Text), DTP2.Value, AccessDebitbookID, Tbx4.Text, 0) == true)
                    {
                        MessageBox.Show("Sửa thông tin giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn đã nhập không đúng quy định, yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
            this.Close();
        }
    }
}
