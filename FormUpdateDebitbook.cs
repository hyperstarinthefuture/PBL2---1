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
    public partial class FormUpdateDebitbook : Form
    {
        private string AccessDebitbookID;
        private string LoanID;
        public FormUpdateDebitbook(string AccessDbbID)
        {
            InitializeComponent();
            AccessDebitbookID = AccessDbbID.Trim(' ');
            ViewDbbInfo();
            LoadData();
        }
        public void ViewDbbInfo()
        {
            string query = "SELECT * FROM dbo.Debitbook WHERE Debitbook_ID = '" + AccessDebitbookID + "'";
            DataProvider provider = new DataProvider();
            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            Tbx1.Text = dr.ItemArray[0].ToString().Trim(' ');
            Tbx2.Text = dr.ItemArray[1].ToString().Trim(' ');
        }
        public bool InsertUpdatingData()
        {
            return DebitbookDAO.Instance.UpdateDebitbook(AccessDebitbookID, Tbx3.Text);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Tbx3.Text != "")
            {
                if (MessageBox.Show("Bạn có muốn thay đổi tên sổ không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (InsertUpdatingData() == true)
                    {
                        MessageBox.Show("Thay đổi tên sổ thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi tên sổ không thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                ViewDbbInfo();
                Tbx3.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên sổ mới!", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void LoadData()
        {
            string query = $"USP_SumDbbMoney @DbbID = {AccessDebitbookID}";
            DataProvider.Instance.ExecuteNonQuery(query);
            query = $"USP_ViewLoanDetails @DbbID = {AccessDebitbookID}";
            DataProvider provider = new DataProvider();
            Dtgv1.DataSource = provider.ExecuteQuery(query);
        }
        private void Btn5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Dtgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Dtgv1.Rows[e.RowIndex];
                LoanID = row.Cells[0].Value.ToString().Trim(' ');
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (LoanID != null)
            {
                FormUpdateLoan f = new FormUpdateLoan(AccessDebitbookID,LoanID);
                this.Hide();
                f.ShowDialog();
                this.Show();
                LoadData();
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (LoanID != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa giao dịch này không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (LoanDAO.Instance.DeleteLoan(LoanID, AccessDebitbookID) == true)
                    {
                        MessageBox.Show("Xóa giao dịch thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            LoadData();
            LoanID = null;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            FormCreateLoan f = new FormCreateLoan(AccessDebitbookID);
            this.Hide();
            f.ShowDialog();
            this.Show();
            LoadData();
        }
    }
}
