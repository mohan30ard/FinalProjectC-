using phase_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.ServiceLayer.Impl
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository));
        }

        public void Deposit(int accountNumber, decimal amount)
        {
            _transactionRepository.Deposit(accountNumber, amount);
        }

        public void Withdraw(int accountNumber, decimal amount)
        {
            _transactionRepository.Withdraw(accountNumber, amount);
        }

        public void Transfer(int fromAccountNumber, int toAccountNumber, decimal amount)
        {
            _transactionRepository.Transfer(fromAccountNumber, toAccountNumber, amount);
        }

        public List<Models.Transaction> GetTransactions(int accountNumber)
        {
            return _transactionRepository.GetTransactions(accountNumber);
        }
    }
}
