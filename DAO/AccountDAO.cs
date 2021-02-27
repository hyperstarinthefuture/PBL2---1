using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PBL2___1.DTO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
namespace PBL2___1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private static string LoginID;
        public static AccountDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
           private set => instance = value; 
        }
        private AccountDAO() { }
        public string HashMD5(string tempstr)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(tempstr);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string pass = "";
            foreach (byte item in hasData)
            {
                pass += item;
            }
            return pass;
        }
        public bool Login(string userName, string passWord)
        {
            string passhash = HashMD5(passWord);
            string queryID = $"USP_GetAccount @UserName = {userName}, @PassWord = {passhash}";
            DataTable result = DataProvider.Instance.ExecuteQuery(queryID, new object[] {userName,passhash});
            if (result.Rows.Count != 0)
            {
                LoginID = result.Rows[0].ItemArray[0].ToString();
            }
            return result.Rows.Count > 0;
        }
        public string GetUserID()
        {
            return LoginID;
        }
        public Account GetAccountLogin(string UserName, string Password)
        {
            string pass = HashMD5(Password);
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM Users WHERE UserName = '" + UserName + "' AND PassWord = '" + pass + "'");
            foreach (DataRow item in dt.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM Users");
        }
        public string GenUserID(string ch)
        {
            string UserID;
            DateTime TempDT = DateTime.Now;
            UserID = TempDT.Year.ToString() + TempDT.Month.ToString() + TempDT.Day.ToString() + TempDT.Hour.ToString() + TempDT.Minute.ToString() + TempDT.Second.ToString() + ch;
            return UserID;
        }
        public bool InsertAccount(string Fullname, DateTime DOB, int Gender,string Username, string Password)
        {
            string pass = HashMD5(Password);
            string query = ("SELECT COUNT(UserID) FROM Users");
            int num = int.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0].ItemArray[0].ToString()) + 1;
            string UserID = "U" + num.ToString();
            query = $"INSERT dbo.Users (UserID,FullName,DayOfbirth,Gender,UserName,PassWordUser) VALUES (N'{UserID}',N'{Fullname}','{DOB}',{Gender},N'{Username}',N'{pass}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(Account TempAcc)
        {
            string pass = HashMD5(TempAcc.PasswordUser);
            string query = string.Format("USP_UpdateAccount2 @UserID = N'{0}', @FullName = N'{1}', @DOB = N'{2}', @Gender = {3}, @UserName = N'{4}', @PassWord = N'{5}'", TempAcc.UseriD, TempAcc.Fullname, TempAcc.DoB, TempAcc.gender, TempAcc.Username, pass);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string AccID)
        {
            string query;
            List<Wallet> WltList = WalletDAO.Instance.GetWalletList(LoginID);
            foreach (Wallet item in WltList)
            {
                WalletDAO.Instance.DeleteWallet(item.wltID);
            }
            List<Debitbook> DbbList = DebitbookDAO.Instance.GetDebitbookList();
            foreach (Debitbook item in DbbList)
            {
                DebitbookDAO.Instance.DeleteDebitbook(item.dbbID);
            }
            query = string.Format("Delete Users WHERE UserID = N'{0}'", AccID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool CheckUsername(string Username)
        {
            string query = string.Format("SELECT UserName FROM Users WHERE UserName = N'{0}'", Username);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
