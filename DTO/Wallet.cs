using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PBL2___1.DTO
{
    public class Wallet
    {
        //Wallet Properties
        private string WltID;
        private string Tittle;
        private double TotalMoney;
        private string UserID;
        //Wallet Properties Method
        public string wltID { get => WltID; set => WltID = value; }
        public string tittle { get => Tittle; set => Tittle = value; }
        public double totalMoney { get => TotalMoney; set => TotalMoney = value; }
        public string userID { get => UserID; set => UserID = value; }
        //Initialize object
        public Wallet(string WltID, string Tittle, double TotalMoney, string UserID)
        {
            this.WltID = WltID;
            this.Tittle = Tittle;
            this.TotalMoney = TotalMoney;
            this.UserID = UserID;
        }
        public Wallet(DataRow row)
        {
            this.WltID = row["Wallet_ID"].ToString();
            this.Tittle = row["Tittle"].ToString();
            this.TotalMoney = Double.Parse(row["TotalMoney"].ToString());
            this.UserID = row["UserID"].ToString();
        }
    }
}
