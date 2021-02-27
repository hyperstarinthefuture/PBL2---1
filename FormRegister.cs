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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CheckData()
        {
            if (Tbx1.Text != "" && Tbx2.Text != "" && Tbx3.Text != "")
            {
                if (RBtn1.Checked == true || RBtn2.Checked == true)
                {
                    if (AccountDAO.Instance.CheckUsername(Tbx2.Text) == false)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        private void Btn1_Click_1(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (RBtn1.Checked == true)
                {
                    if (AccountDAO.Instance.InsertAccount(Tbx1.Text, DTP1.Value,1,Tbx2.Text,Tbx3.Text) == true)
                    {
                        MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    if (AccountDAO.Instance.InsertAccount(Tbx1.Text, DTP1.Value, 0, Tbx2.Text, Tbx3.Text) == true)
                    {
                        MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("!!!!!", "Thông báo", MessageBoxButtons.OK);
            }    
        }
    }
}
