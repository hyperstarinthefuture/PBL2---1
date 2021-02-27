using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PBL2___1.DTO
{
    public class Debitbook
    {
        //Debitbook Properties
        private string DbbID;
        private string Tittle;
        private string UserID;
        //Debitbook Properties Method
        public string dbbID { get => DbbID; set => DbbID = value; }
        public string tittle { get => Tittle; set => Tittle = value; }
        public string userID { get => UserID; set => UserID = value; }
        //Initialize object
        public Debitbook(string DbbID, string Tittle, string UserID)
        {
            this.DbbID = DbbID;
            this.Tittle = Tittle;
            this.UserID = UserID;
        }
        public Debitbook(DataRow row)
        {
            this.DbbID = row["Debitbook_ID"].ToString();
            this.Tittle = row["Tittle"].ToString();
            this.UserID = row["UserID"].ToString();
        }
    }
}
