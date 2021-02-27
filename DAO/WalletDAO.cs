using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL2___1.DTO;
using System.Data;
namespace PBL2___1.DAO
{
    public class WalletDAO
    {
        private static WalletDAO instance;
        public static WalletDAO Instance
        {
            get { if (instance == null) instance = new WalletDAO(); return instance; }
            private set { WalletDAO.Instance = value; }
        }
        private WalletDAO() { }
        public string GenWalletID()
        {
            string WalletID;
            DateTime TempDT = DateTime.Now;
            string ch = AccountDAO.Instance.GetUserID();
            ch = ch.Substring(ch.Length - 1,1);
            WalletID = "W" + TempDT.Year.ToString() + TempDT.Month.ToString() + TempDT.Day.ToString() + TempDT.Hour.ToString() + TempDT.Minute.ToString() + TempDT.Second.ToString() + ch;
            return WalletID;
        }
        public List<Wallet> GetWalletsByWalletID(string WltID)
        {
            List<Wallet> Wallets = new List<Wallet>();
            string query = "SELECT * FROM Wallet WHERE WalletID = '" + WltID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Wallet wallet = new Wallet(item);
                Wallets.Add(wallet);
            }
            return Wallets;
        }
        public List<Wallet> GetWalletList(string UserID)
        {
            List<Wallet> Wallets = new List<Wallet>();
            string query = $"SELECT * FROM Wallet WHERE UserID = N'{UserID}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Wallet wallet = new Wallet(item);
                Wallets.Add(wallet);
            }
            return Wallets;
        }
        public List<Wallet> SearchWalletByTittle(string Tittle)
        {
            List<Wallet> Wallets = new List<Wallet>();
            string query = string.Format("SELECT * FROM Wallet WHERE Tittle LIKE N'%{0}%'", Tittle);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Wallet wallet = new Wallet(item);
                Wallets.Add(wallet);
            }
            return Wallets;
        }
        public bool InsertWallet(string WltID,string Tittle, double TotalMoney, DateTime DC, string UserID)
        {
            //string query = string.Format("INSERT dbo.Wallet (WltID,Tittle,TotalMoney,UserID) VALUE ( N'{0}',{1},{2})", WltID, Tittle, TotalMoney, UserID);
            string query = $"INSERT dbo.Wallet (Wallet_ID,Tittle,TotalMoney,Date_Created,UserID) VALUES ( N'{WltID}',N'{Tittle}',{TotalMoney},'{DC}',N'{UserID}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateWallet(string WltID, string Tittle)
        {
            string query = string.Format("UPDATE Wallet SET Tittle = N'{0}' WHERE Wallet_ID = N'{1}'", Tittle, WltID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void DeleteWallet(string WltID)
        {
            string query;
            query = string.Format("DELETE Expense WHERE Wallet_ID = N'{0}'", WltID);
            DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("DELETE Income WHERE Wallet_ID = N'{0}'", WltID);
            DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("DELETE Wallet WHERE Wallet_ID = N'{0}'", WltID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
    
}
