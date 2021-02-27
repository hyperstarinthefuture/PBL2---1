using System;
using System.Collections;
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
    public partial class FormStatistics : Form
    {
        private string UserID;
        public FormStatistics(string userID)
        {
            InitializeComponent();
            UserID = userID;
            LoadData();

        }
        public void LoadData()
        {
            string ItemQuery = "'" + AccountDAO.Instance.GetUserID().Trim(' ') + "'";
            string query = "SELECT Tittle,Wallet_ID FROM dbo.Wallet JOIN dbo.Users ON Wallet.UserID = Users.UserID WHERE Users.UserID = " + ItemQuery;
            DataProvider provider = new DataProvider();
            Cbb1.DataSource = provider.ExecuteQuery(query);
            Cbb1.DisplayMember = "Tittle";
            Cbb1.ValueMember = "Wallet_ID";
        }
        public bool CheckData()
        {
            if (Cbb1.SelectedItem == null || Cbb2.SelectedItem == null)
            {
                return false;
            }
            else
            {
                if (DTP1.Value > DTP2.Value)
                {
                    return false;
                }
            }    
            return true;
        }
        public void statistics(string query, int type)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            int len = dt.Rows.Count;
            if (len == 0)
            {
                MessageBox.Show("Không có giao dịch trong khoảng thời gian này!","Thông báo",MessageBoxButtons.OK);
                return;
            }
            double[] ArrDb = new double[len];
            int d;
            if (type == 1)
            {
                d = 1;
            }
            else
            {
                d = -1;
            }
            for (int i = 0; i < len; i++)
            {
                DataRow dr = dt.Rows[i]; 
                ArrDb[i] = Double.Parse(dr.ItemArray[0].ToString()) * d;
            }
            MaxHeap stc = new MaxHeap(ArrDb, len);
            foreach (DataRow item in dt.Rows)
            {
                if (Double.Parse(item.ItemArray[0].ToString()) == d * (stc.Maximum()))
                {
                    Tbx1.Text = item.ItemArray[0].ToString();
                    Tbx2.Text = item.ItemArray[1].ToString();
                    Tbx3.Text = item.ItemArray[2].ToString();
                }
            }
        }
        public void FillChart(string query, int type)
        {
            C1.DataSource = DataProvider.Instance.ExecuteQuery(query);
            if (type == 1)
            {
                C1.Series["Series1"].XValueMember = "Nguồn thu";
                C1.Series["Series1"].YValueMembers = "Số tiền đã thu";
            }
            else
            {
                C1.Series["Series1"].XValueMember = "Mục đích chi tiêu";
                C1.Series["Series1"].YValueMembers = "Số tiền đã chi";
            }
            C1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private void Btn1_Click(object sender, EventArgs e)
        {
            string query;
            if (CheckData() == true)
            {
                if (Cbb2.Text == "Thu vào")
                {
                    query = $"USP_SumIncome5 @WltID = N'{Cbb1.SelectedValue.ToString().Trim(' ')}', @From = '{DTP1.Value}',@To = '{DTP2.Value}'";
                    FillChart(query,1);
                    query = $"USP_SearchInc3 @WltID = N'{Cbb1.SelectedValue.ToString().Trim(' ')}', @from = '{DTP1.Value}',@to = '{DTP2.Value}'";
                    statistics(query,1);
                }
                else
                {
                    query = $"USP_SumExpense4 @WltID = N'{Cbb1.SelectedValue.ToString().Trim(' ')}', @From = '{DTP1.Value}',@To = '{DTP2.Value}'";
                    FillChart(query,2);
                    query = $"USP_SearchExp @WltID = N'{Cbb1.SelectedValue.ToString().Trim(' ')}', @from = '{DTP1.Value}',@to = '{DTP2.Value}'";
                    statistics(query,2);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn dữ liệu để thống kê!", "Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void Cbb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void C1_Click(object sender, EventArgs e)
        {

        }
        public class MaxHeap
        {
            public MaxHeap(double[] input, int length)
            {
                this.Length = length;
                this.Array = input;
                BuildMaxHeap();
            }
            public double[] Array { get; private set; }

            public int Length { get; private set; }

            private void BuildMaxHeap()
            {
                for (int i = this.Length / 2; i > 0; i--)
                {
                    MaxHeapify(i);
                }

                return;
            }

            public void MaxHeapify(int index)
            {
                var left = 2 * index;
                var right = 2 * index + 1;

                int max = index;
                if (left <= this.Length && this.Array[left - 1] > this.Array[index - 1])
                {
                    max = left;
                }

                if (right <= this.Length && this.Array[right - 1] > this.Array[max - 1])
                {
                    max = right;
                }

                if (max != index)
                {
                    double temp = this.Array[max - 1];
                    this.Array[max - 1] = this.Array[index - 1];
                    this.Array[index - 1] = temp;
                    MaxHeapify(max);
                }

                return;
            }

            public double Maximum()
            {
                return this.Array[0];
            }
            public string rs;
            public string pointtime;
            public int len;
        }
    }
}
