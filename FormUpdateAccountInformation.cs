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
    public partial class FormUpdateAccountInformation : Form
    {
        private int AllowUpdateStatus = 0;
        public FormUpdateAccountInformation()
        {
            InitializeComponent();
            Tbx0.Text = AccountDAO.Instance.GetUserID();
            ViewAccountInfo();
        }
        public void ViewAccountInfo()
        {
            string query = "SELECT * FROM dbo.Users WHERE UserID = '" + AccountDAO.Instance.GetUserID() + "'";
            DataProvider provider = new DataProvider();
            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            Tbx0.Text = dr.ItemArray[0].ToString().Trim(' ');
            Tbx1.Text = dr.ItemArray[1].ToString().Trim(' ');
            DTP1.Value = Convert.ToDateTime(dr.ItemArray[2]);
            if (dr.ItemArray[3].ToString().Trim(' ') == "Nam")
            {
                RBtn1.Checked = true;
            }
            else
            {
                RBtn1.Checked = true;
            }
            Tbx2.Text = dr.ItemArray[4].ToString().Trim(' ');
        }
        public void CheckData()
        {
            if (Tbx1.Text != "" && Tbx2.Text != "" && Tbx3.Text != "" && (Tbx3.Text == Tbx4.Text))
            {
                AllowUpdateStatus = 1;
            }
        }
        public bool InsertUpdatingInfo()
        { 
            if (AllowUpdateStatus == 1)
            {
                string ch = "";
                string temp = Tbx1.Text;
                for (int i = Tbx1.Text.Length - 1;i >= 0;i--)
                {
                    if (temp[i] == ' ')
                    {
                        ch = ch + temp[i+1];
                        break;
                    }
                }
                string UserIDNew = AccountDAO.Instance.GenUserID(ch);
                bool Temp = true;
                if (RBtn2.Checked == true)
                {
                    Temp = false;
                }
                Account TempAcc = new Account(Tbx0.Text, Tbx1.Text, DTP1.Value, Temp, Tbx2.Text, Tbx3.Text);
                AccountDAO.Instance.UpdateAccount(TempAcc);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            CheckData();
            if (AllowUpdateStatus == 1)
            {
                MessageBox.Show("Dữ liệu đã nhập phù hợp để cập nhật!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dữ liệu bạn đã nhập không đúng quy định, yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (InsertUpdatingInfo() == true)
            {
                MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            this.Close();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
