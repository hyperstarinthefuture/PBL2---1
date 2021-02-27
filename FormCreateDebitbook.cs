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
    public partial class FormCreateDebitbook : Form
    {
        private int AllowCreateStatus = 0;
        public FormCreateDebitbook()
        {
            InitializeComponent();
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            if (Tbx1.Text != "")
            {
                if (DebitbookDAO.Instance.InsertDebitbook(Tbx1.Text,AccountDAO.Instance.GetUserID()) == true)
                {
                    MessageBox.Show("Tạo sổ nợ mới thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK);
            }    


        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát và mất toàn bộ dữ liệu dữ liệu đã nhập?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormCreateDebitbook_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
