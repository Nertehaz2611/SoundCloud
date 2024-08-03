using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class AccountBLL
    {
        SqlConnectionData connector = null;
        public AccountBLL()
        {
            connector = new SqlConnectionData();
        }
        public List<Account> getListAccounts()
        {
            SqlDataReader dr = null;
            List<Account> list = null;
            dr = connector.getData("SELECT * FROM Accounts");
            list = new List<Account>();
            while (dr.Read())
            {
                Account account = new Account();
                account.username = dr.GetString(0);
                account.password = dr.GetString(1);
                account.email = dr.GetString(2);
                list.Add(account);
            }
            connector.closeConnection();
          
            return list;
        }
        public void AddAccout(Account account)
        {
            string username = account.username;
            string password = account.password;
            string email = account.email;
            connector.openConnection();
            string query = "INSERT INTO Accounts (Username, Password, Email) VALUES ('" + username + "', '" + password + "', '" + email + "')";
            connector.setData(query);
        }
    }
}
