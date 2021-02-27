using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PBL2___1.DTO;
namespace PBL2___1.DAO
{
    public class LoanDAO
    {
        private static LoanDAO instance;
        public static LoanDAO Instance
        {
            get { if (instance == null) instance = new LoanDAO(); return instance; }
            private set { LoanDAO.Instance = value; }
        }
        private LoanDAO() { }
        public List<Loan> GetLoanByLoanID(string LoanID)
        {
            List<Loan> LoanList = new List<Loan>();
            string query = "SELECT * FROM Loan WHERE LoanID = '" + LoanID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Loan loan = new Loan(item);
                LoanList.Add(loan);
            }
            return LoanList;
        }
        public List<Loan> GetLoanList()
        {
            List<Loan> LoanList = new List<Loan>();
            string query = "SELECT * FROM Loan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Loan loan = new Loan(item);
                LoanList.Add(loan);
            }
            return LoanList;
        }
        public List<Loan> SearchLoanByDetails(string Details)
        {
            List<Loan> LoanList = new List<Loan>();
            string query = string.Format("SELECT * FROM Loan WHERE Details LIKE N'%{0}%'", Details);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Loan loan = new Loan(item);
                LoanList.Add(loan);
            }
            return LoanList;
        }
        public bool InsertLoan(double LoanMoney, string Bank, DateTime DC, double Rate, DateTime Term, string DbbID, string Details, int Status)
        {
            string query = ("SELECT COUNT(Loan_ID) FROM Loan");
            int num = int.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0].ItemArray[0].ToString()) + 1;
            string Loan_ID = "L" + num.ToString();
            //string query = string.Format("INSERT dbo.Loan (LoanID,LoanMoney,Bank,Rate,Term,DbbID,Details) VALUE (N'{0}',{1},N'{2}',{3},N'{4}',N'{5}',N'{6}'", LoanID, LoanMoney, Bank, Rate, Term, DbbID, Details);
            query = $"INSERT dbo.Loan (Loan_ID,MoneyLoan,Bank,Date_Checked,Rate,Term,Debitbook_ID,Details,StatusLoan) VALUES (N'{Loan_ID}',{LoanMoney},N'{Bank}','{DC}',{Rate},'{Term}',N'{DbbID}',N'{Details}',{Status})";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateLoan(string LoanID,double LoanMoney, string Bank,DateTime DC, double Rate, DateTime Term, string DbbID, string Details, int Status)
        {
            //string query = string.Format("UPDATE Loan set LoanID = N'{0}', LoanMoney = {1}, Bank = N'{2}', Rate = {3}, Term = N'{4}', DbbID = N'{5}', Details = N'{6}'", LoanID, LoanMoney, Bank, Rate, Term, DbbID, Details);
            string query = $"UPDATE Loan SET MoneyLoan = {LoanMoney}, Bank = N'{Bank}',Date_Checked = '{DC}', Rate = {Rate}, Term = '{Term}',Debitbook_ID = N'{DbbID}',Details = N'{Details}',StatusLoan = {Status} WHERE Loan_ID = N'{LoanID}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteLoan(string LoanID, string DebitbookID)
        {
            //string query = string.Format("DELETE Loan WHERE Loan_ID = N'{0}' AND Debitbook_ID = N'{1}'", LoanID,DebitbookID);
            string query = $"DELETE Loan WHERE Loan_ID = N'{LoanID}' AND Debitbook_ID = N'{DebitbookID}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
