using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PBL2___1.DTO
{
    public class Account
    {
        //Account Properties
        private string UserID;
        private string FullName;
        private DateTime DOB;
        private bool Gender;
        private string UserName;
        private string PassWordUser;
        //Account Properties Method
        public string UseriD { get => UserID; set => UserID = value; }
        public string Fullname { get => FullName; set => FullName = value; }
        public DateTime DoB { get => DOB; set => DOB = value; }
        public bool gender { get => Gender; set => Gender = value; }
        public string Username { get => UserName; set => UserName = value; }
        public string PasswordUser { get => PassWordUser; set => PassWordUser = value; }
        //Initialize Object
        public Account(string UserID, string FullName, DateTime DOB, bool Gender, string UserName,  string PassWorduser)
        {
            this.UserID = UserID;
            this.FullName = FullName;
            this.DOB = DOB;
            this.Gender = Gender;
            this.Username = UserName;
            this.PasswordUser = PassWorduser;
        }
        public Account(DataRow row)
        {
            this.UserID = row["UserID"].ToString();
            this.FullName = row["FullName"].ToString();
            this.DOB = Convert.ToDateTime(row["DOB"]);
            this.Gender = Convert.ToBoolean(row["Gender"]);
            this.UserName = row["UserName"].ToString();
            this.PassWordUser = row["PassWordUser"].ToString();
        }
    }
}
