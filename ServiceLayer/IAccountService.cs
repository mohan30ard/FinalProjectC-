using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.ServiceLayer
{
    public interface IAccountService
    {
        void CreateAccount(Models.Account account);
        void UpdateAccount(Models.Account account);
        void DeleteAccount(int accountNumber);
        Models.Account GetAccount(int accountNumber);

        Models.Account GetAccount(string username);
        List<Models.Account> GetAccounts();

        int GenerateAccountNumber();

        string GenerateUserName(string name, string phoneNumber);

        public string AddtoListBox(Models.Account account);
    }
}
