using phase_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.Repositories.Impl
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly BankDBContext _context;

        public TransactionRepository(BankDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Deposit(int accountNumber, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            }

            var account = _context.Accounts.Find(accountNumber);
            if (account == null)
            {
                throw new ArgumentException("Account not found", nameof(accountNumber));
            }

            // Update account balance
            account.Balance += amount;

            // Create a new transaction record
            var transaction = new Models.Transaction
            {
                AccountNumber = accountNumber,
                Amount = amount,
                TransactionType = "Deposit",
                TransactionDate = DateTime.Now
            };

            // Add transaction to the database
            _context.Transactions.Add(transaction);

            // Save changes to the database
            _context.SaveChanges();
        }

        public List<Models.Transaction> GetTransactions(int accountNumber)
        {
            // Retrieve transactions for the specified account
            var transactions = _context.Transactions
                .Where(t => t.AccountNumber == accountNumber)
                .OrderByDescending(t => t.TransactionDate)
                .ToList();

            return transactions;
        }

        public void Transfer(int fromAccountNumber, int toAccountNumber, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            }

            var fromAccount = _context.Accounts.Find(fromAccountNumber);
            var toAccount = _context.Accounts.Find(toAccountNumber);

            if (fromAccount == null || toAccount == null)
            {
                throw new ArgumentException("Invalid account numbers", nameof(fromAccountNumber));
            }

            if (fromAccount.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds for transfer");
            }

            // Update account balances
            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            // Create transaction records for both accounts
            var fromTransaction = new Models.Transaction
            {
                AccountNumber = fromAccountNumber,
                Amount = -amount,
                TransactionType = "Transfer",
                TransactionDate = DateTime.Now
            };

            var toTransaction = new Models.Transaction
            {
                AccountNumber = toAccountNumber,
                Amount = amount,
                TransactionType = "Transfer",
                TransactionDate = DateTime.Now
            };

            // Add transactions to the database
            _context.Transactions.Add(fromTransaction);
            _context.Transactions.Add(toTransaction);

            // Save changes to the database
            _context.SaveChanges();
        }

        public void Withdraw(int accountNumber, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero", nameof(amount));
            }

            var account = _context.Accounts.Find(accountNumber);
            if (account == null)
            {
                throw new ArgumentException("Account not found", nameof(accountNumber));
            }

            if (account.Balance < amount)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal");
            }

            // Update account balance
            account.Balance -= amount;

            // Create a new transaction record
            var transaction = new Models.Transaction
            {
                AccountNumber = accountNumber,
                Amount = -amount,
                TransactionType = "Withdrawal",
                TransactionDate = DateTime.Now
            };

            // Add transaction to the database
            _context.Transactions.Add(transaction);

            // Save changes to the database
            _context.SaveChanges();
        }
    }
}
