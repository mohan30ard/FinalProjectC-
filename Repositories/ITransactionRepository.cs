using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.Repositories
{
    public interface ITransactionRepository
    {
        public void Deposit(int accountNumber, decimal amount);
        public void Withdraw(int accountNumber, decimal amount);
        public void Transfer(int fromAccountNumber, int toAccountNumber, decimal amount);
        public List<Models.Transaction> GetTransactions(int accountNumber);
    }
}
