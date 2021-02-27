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
    public partial class FormViewAccountInfo : Form
    {
        public FormViewAccountInfo()
        {
            InitializeComponent();
            ViewAccountInfo();
        }
        public void ViewAccountInfo()
        {
            string query = "SELECT * FROM dbo.Users WHERE UserID = '" + AccountDAO.Instance.GetUserID() + "'";
            DataProvider provider = new DataProvider();
            DataTable dt = provider.ExecuteQuery(query);
            DataRow dr = dt.Rows[0];
            Tbx1.Text = dr.ItemArray[0].ToString().Trim(' ');
            Tbx2.Text = dr.ItemArray[1].ToString().Trim(' ');
            Tbx3.Text = dr.ItemArray[2].ToString().Trim(' ');
            if (dr.ItemArray[3].ToString().Trim(' ') == "True")
            {
                Tbx4.Text = "Nam";
            }    
            else
            {
                Tbx4.Text = "Nữ";
            }
            Tbx5.Text = dr.ItemArray[4].ToString().Trim(' ');
        }

    }
}
