using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        private string Username;
        private string Password;

        public AccountDTO()
        {
        }

        public AccountDTO(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
