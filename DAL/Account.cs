using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Account
    {
        DbAccess db = new DbAccess();

        public bool CheckAccount(AccountDTO Acc)
        {
            string query = "Select Count(username) From Account Where username='" + Acc.Username1 + "' and password='" + Acc.Password1 + "'";
            try
            {
                int rowsAffected = db.ExcuteScalar(query);
                return rowsAffected >0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
