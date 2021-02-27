using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PBL2___1.DTO;
namespace PBL2___1.DAO
{
    public class ExchangeDAO
    {
        private static ExchangeDAO instance;
        public static ExchangeDAO Instance
        {
            get { if (instance == null) instance = new ExchangeDAO(); return instance; }
            private set { ExchangeDAO.Instance = value; }
        }
        private ExchangeDAO() { }
        public List<Exchange> GetExchangebyExchangeID(string ExchangeID)
        {
            List<Exchange> ExchangeList = new List<Exchange>();
            string query = "SELECT * FROM Exchange WHERE ExchangeID = '" + ExchangeID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Exchange exchange = new Exchange(item);
                ExchangeList.Add(exchange);
            }
            return ExchangeList;
        }
        public List<Exchange> GetExchangeList()
        {
            List<Exchange> ExchangeList = new List<Exchange>();
            string query = "SELECT * FROM Exchange";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in dt.Rows)
            {
                Exchange exchange = new Exchange(item);
                ExchangeList.Add(exchange);
            }
            return ExchangeList;
        }
        public List<Exchange> SearchExchangeByDetails(string Details)
        {
            List<Exchange> ExchangeList = new List<Exchange>();
            string query = string.Format("SELECT * FROM Exchange WHERE Details LIKE N'%{0}%'", Details);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Exchange exchange = new Exchange(item);
                ExchangeList.Add(exchange);
            }
            return ExchangeList;        
        }
        public bool InsertExchange(int Type, string ExchangeID, int FromtoID, double ExchangeMoney, DateTime DateChecked, string WltID, string Details)
        {
            string query;
            if (Type == 1)
            {
                //query = string.Format("INSERT dbo.Income (Income_ID,Source_ID,Money_Income,Date_Checked,Wallet_ID,Details) VALUES (N'{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}'", ExchangeID, FromtoID, ExchangeMoney, DateChecked, WltID, Details);
                query = $"INSERT Income (Income_ID,Source_ID,Money_Income,Date_Checked,Wallet_ID,Details) VALUES (N'{ExchangeID}',{FromtoID},{ExchangeMoney},'{DateChecked}',N'{WltID}',N'{Details}')";
            }   
            else
            {
                //query = string.Format("INSERT dbo.Expense (Expense_ID,Reason_ID,Money_Expense,Date_Checked,Wallet_ID,Details) VALUES (N'{0}',N'{1}',{2},N'{3}',N'{4}',N'{5}'", ExchangeID, FromtoID, ExchangeMoney, DateChecked, WltID, Details);
                query = $"INSERT Expense (Expense_ID,Reason_ID,Money_Expense,Date_Checked,Wallet_ID,Details) VALUES (N'{ExchangeID}',{FromtoID},{ExchangeMoney},'{DateChecked}',N'{WltID}',N'{Details}')";
            }
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                query = $"UPDATE Wallet SET TotalMoney = TotalMoney + {ExchangeMoney} WHERE Wallet_ID = N'{WltID}'";
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            return result > 0;
        }
        public bool UpdateExchange(int ExchangeType, string ExchangeID, int FromtoID, double ExchangeMoney,double money1, DateTime DateChecked, string WltID, string Details)
        {
            string query;
            if (ExchangeType == 1)
            {
                query = string.Format("UPDATE Income set Source_ID = {0}, Money_Income = {1}, Date_Checked = N'{2}', Details = N'{3}' WHERE Income_ID = N'{4}' AND Wallet_ID = N'{5}'",FromtoID, ExchangeMoney, DateChecked,Details, ExchangeID, WltID);
            }
            else
            {
                query = string.Format("UPDATE Expense set Reason_ID = {0}, Money_Expense = {1}, Date_Checked = N'{2}', Details = N'{3}' WHERE Expense_ID = N'{4}' AND Wallet_ID = N'{5}'", FromtoID, ExchangeMoney, DateChecked, Details, ExchangeID, WltID);
            }
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result > 0)
            {
                query = $"UPDATE Wallet SET TotalMoney = TotalMoney - {money1} + {ExchangeMoney} WHERE Wallet_ID = N'{WltID}'";
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }    
            return result > 0;
        }
        public bool DeleteExchange(int Type, string ExchangeID,double money,string WalletID)
        {
            string query;
            int result;
            if (Type == 1)
            {
                query = string.Format("DELETE Income WHERE Income_ID = N'{0}' AND Wallet_ID = N'{1}'", ExchangeID, WalletID);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                }
            else
            {
                query = string.Format("DELETE Expense WHERE Expense_ID = N'{0}' AND Wallet_ID = N'{1}'", ExchangeID, WalletID);
                result = DataProvider.Instance.ExecuteNonQuery(query);
            }
            if (result > 0)
            {
                query = $"UPDATE Wallet SET TotalMoney = TotalMoney - {money} WHERE Wallet_ID = N'{WalletID}'";
                result = DataProvider.Instance.ExecuteNonQuery(query);

            }
            return result > 0;
        }
        //Generate ExchangeID
        public string GenExchangeID(int type,string ch)
        {
            string ExchangeID;
            DateTime TempDT = DateTime.Now;
            if (type == 1)
            {
                ExchangeID = "I" + TempDT.Year.ToString() + TempDT.Month.ToString() + TempDT.Day.ToString() + TempDT.Hour.ToString() + TempDT.Minute.ToString() + TempDT.Second.ToString() + ch;
            }
            else
            {
                ExchangeID = "E" + TempDT.Year.ToString() + TempDT.Month.ToString() + TempDT.Day.ToString() + TempDT.Hour.ToString() + TempDT.Minute.ToString() + TempDT.Second.ToString() + ch;
            }
            return ExchangeID;
        }
    }

}
