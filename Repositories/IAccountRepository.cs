using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.Repositories
{
    public interface IAccountRepository
    {
        public void CreateAccount(Models.Account account);
        public void UpdateAccount(Models.Account account);
        public void DeleteAccount(int accountNumber);
        public List<Models.Account> GetAccounts();
        public Models.Account GetAccount(int id);

        public Models.Account GetAccount(string username);

    }
}
