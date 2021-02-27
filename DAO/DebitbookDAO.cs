using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PBL2___1.DTO;
namespace PBL2___1.DAO
{
    public class DebitbookDAO
    {
        private static DebitbookDAO instance;
        public static DebitbookDAO Instance
        {
            get { if (instance == null) instance = new DebitbookDAO(); return instance; }
            private set { DebitbookDAO.Instance = value; }
        }
        private DebitbookDAO() { }
        public List<Debitbook> GetDebitbookByDebitbookID(string DbbID)
        {
            List<Debitbook> DbbList = new List<Debitbook>();
            string query = "SELECT * FROM Debitbook WHERE DbbID = '" + DbbID + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Debitbook Dbb = new Debitbook(item);
                DbbList.Add(Dbb);
            }
            return DbbList;
        }
        public List<Debitbook> GetDebitbookList()
        {
            List<Debitbook> DbbList = new List<Debitbook>();
            string query = "SELECT * FROM Debitbook";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Debitbook Dbb = new Debitbook(item);
                DbbList.Add(Dbb);
            }
            return DbbList;
        }
        public List<Debitbook> SearchDebitbookByTittle(string Tittle)
        {
            List<Debitbook> DbbList = new List<Debitbook>();
            string query = string.Format("SELECT * FROM Debitbook LIKE N'%{0}%'", Tittle);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                Debitbook Dbb = new Debitbook(item);
                DbbList.Add(Dbb);
            }
            return DbbList;
        }
        public bool InsertDebitbook(string Tittle, string UserID)
        {
            string query = ("SELECT COUNT(Debitbook_ID) FROM Debitbook");
            int num = int.Parse(DataProvider.Instance.ExecuteQuery(query).Rows[0].ItemArray[0].ToString()) + 1;
            string DbbID = "D" + num.ToString();
            //query = string.Format("INSERT dbo.Debitbook (DbbID,Tittle,UserID) VALUE (N'{0}',N'{1}',N'{2}')", DbbID, Tittle, UserID);
            query = $"INSERT dbo.Debitbook (Debitbook_ID,Tittle,Date_Created,UserID,TotalMoney) VALUES (N'{DbbID}',N'{Tittle}','{DateTime.Now}',N'{UserID}',{0})";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateDebitbook(string DbbID, string Tittle)
        {
            string query = string.Format("UPDATE Debitbook set Tittle = N'{0}' WHERE Debitbook_ID = N'{1}'", Tittle, DbbID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void DeleteDebitbook(string DbbID)
        {
            string query;
            query = string.Format("DELETE Loan WHERE Debitbook_ID = N'{0}'", DbbID);
            DataProvider.Instance.ExecuteNonQuery(query);
            query = string.Format("DELETE Debitbook WHERE Debitbook_ID = N'{0}'", DbbID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
