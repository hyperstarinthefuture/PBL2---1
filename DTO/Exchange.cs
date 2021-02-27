using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PBL2___1.DTO
{
    public class Exchange
    {
        //Exchange Properties
        private string ExchangeID;
        private string FromtoID;
        private double ExchangeMoney;
        private string DateChecked;
        private string WltID;
        private string Details;
        //Exchange Properties Method
        public string exchangeID { get => ExchangeID; set => ExchangeID = value; }
        public string fromtoID { get => FromtoID; set => FromtoID = value; }
        public double exchangeMoney { get => ExchangeMoney; set => ExchangeMoney = value; }
        public string dateChecked { get => DateChecked; set => DateChecked = value; }
        public string wltID { get => WltID; set => WltID = value; }
        public string details { get => Details; set => Details = value; }
        //Initialize Object
        public Exchange(string ExchangeID, string FromtoID, double ExchangeMoney, string DateChecked, string WltID, string Details)
        {
            this.ExchangeID = ExchangeID;
            this.FromtoID = FromtoID;
            this.ExchangeMoney = ExchangeMoney;
            this.DateChecked = DateChecked;
            this.WltID = WltID;
            this.Details = Details;
        }
        public Exchange(DataRow row)
        {
            this.ExchangeID = row["ExchangeID"].ToString();
            this.FromtoID = row["FromtoID"].ToString();
            this.ExchangeMoney = Double.Parse(row["ExchangeMoney"].ToString());
            this.DateChecked = row["DateChecked"].ToString();
            this.WltID = row["WltID"].ToString();
            this.Details = row["Details"].ToString();
        }
    }
}
