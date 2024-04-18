using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.ServiceLayer
{
    public interface ITransactionService
    {
        void Deposit(int accountNumber, decimal amount);
        void Withdraw(int accountNumber, decimal amount);
        void Transfer(int fromAccountNumber, int toAccountNumber, decimal amount);
        List<Models.Transaction> GetTransactions(int accountNumber);
    }
}
