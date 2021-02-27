using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using PBL2___1.DAO;
using PBL2___1.DTO;
namespace PBL2___1
{
    public partial class FormCreateWallet : Form
    {
        private int AllowCreateStatus = 0;
        public FormCreateWallet()
        {
            InitializeComponent();
        }
        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Tbx1.Text != "" && Tbx2.Text != "" && Double.Parse(Tbx2.Text) >= 0)
            {
                AllowCreateStatus = 1;
                MessageBox.Show("Dữ liệu đã nhập phù hợp để tạo ví mới!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Dữ liệu đã nhập không phù hợp để tạo ví mới,yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }    
        }
        private void Btn2_Click(object sender, EventArgs e)
        {
            if (AllowCreateStatus == 1)
            {
                if (WalletDAO.Instance.InsertWallet(WalletDAO.Instance.GenWalletID(),Tbx1.Text,Double.Parse(Tbx2.Text),DateTime.Now,AccountDAO.Instance.GetUserID()) == true)
                {
                    MessageBox.Show("Tạo ví mới thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                AllowCreateStatus = 2;
                this.Close();
            }
            else
            {
                MessageBox.Show("Dữ liệu đã nhập không phù hợp để tạo ví mới,yêu cầu nhập lại!", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
