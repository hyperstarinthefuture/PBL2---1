using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PBL2___1.DTO
{
    public class Loan
    {
        //Loan Properties
        private string LoanID;
        private double LoanMoney;
        private string Bank;
        private double Rate;
        private string Term;
        private string DbbID;
        private string Details;
        //Loan Properties Method
        public string loanID { get => LoanID; set => LoanID = value; }
        public double loanMoney { get => LoanMoney; set => LoanMoney = value; }
        public string bank { get => Bank; set => Bank = value; }
        public double rate { get => Rate; set => Rate = value; }
        public string term { get => Term; set => Term = value; }
        public string dbbID { get => DbbID; set => DbbID = value; }
        public string details { get => Details; set => Details = value; }
        //Initialize Object
        public Loan(string LoanID, double LoanMoney, string Bank, double Rate, string Term, string DbbID, string Details)
        {
            this.LoanID = LoanID;
            this.LoanMoney = LoanMoney;
            this.Bank = Bank;
            this.Rate = Rate;
            this.Term = Term;
            this.DbbID = DbbID;
            this.Details = Details;
        }
        public Loan(DataRow row)
        {
            this.LoanID = row["LoanID"].ToString();
            this.LoanMoney = Double.Parse(row["LoanMoney"].ToString());
            this.Bank = row["Bank"].ToString();
            this.Rate = Double.Parse(row["Rate"].ToString());
            this.Term = row["Term"].ToString();
            this.DbbID = row["DbbID"].ToString();
            this.Details = row["Details"].ToString();
        }
    }
}
