using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AccountBUS
    {
        Account _Acc = new Account();
        public bool CheckAccount(AccountDTO Acc)
        {
            return _Acc.CheckAccount(Acc);
        }
    }
}
