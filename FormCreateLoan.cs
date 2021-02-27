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
    public partial class FormCreateLoan : Form
    {
        private string AccessDebitbookID;
        public FormCreateLoan(string DbbID)
        {
            InitializeComponent();
            AccessDebitbookID = DbbID;
        }
        public bool CheckData()
        {
            if (Tbx1.Text != "" && Tbx2.Text != "" && Tbx3.Text != "" && Tbx4.Text != "")
            {
                if (DTP1.Value < DTP2.Value)
                {
                    if (RBtn1.Checked == true || RBtn2.Checked == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (RBtn1.Checked == true)
                {
                    if (LoanDAO.Instance.InsertLoan(Double.Parse(Tbx1.Text), Tbx2.Text, DTP1.Value, Double.Parse(Tbx3.Text), DTP2.Value,AccessDebitbookID, Tbx4.Text, 1) == true)
                    {
                        MessageBox.Show("Thêm giao dịch mới thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (LoanDAO.Instance.InsertLoan(Double.Parse(Tbx1.Text), Tbx2.Text, DTP1.Value, Double.Parse(Tbx3.Text), DTP2.Value,AccessDebitbookID, Tbx4.Text, 0) == true)
                    {
                        MessageBox.Show("Thêm giao dịch mới thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn nhập chưa phù hợp, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }    
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
