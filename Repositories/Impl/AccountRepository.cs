using Microsoft.Identity.Client.NativeInterop;
using phase_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace phase_1.Repositories.Impl
{
    public class AccountRepository : IAccountRepository
    {

        private readonly BankDBContext _context;

        public AccountRepository(BankDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void CreateAccount(Models.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void DeleteAccount(int accountNumber)
        {
            var account = _context.Accounts.Find(accountNumber);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Account not found", nameof(accountNumber));
            }
        }

        public List<Models.Account> GetAccounts()
        {
            var accounts = _context.Accounts.ToList();
            return accounts;
        }

        public void UpdateAccount(Models.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _context.Accounts.Update(account);
            _context.SaveChanges();
        }

        public Models.Account GetAccount(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Invalid account ID");
            }

            var account = _context.Accounts.Find(id);

            if (account == null)
            {
                throw new ArgumentException("Account not found", nameof(id));
            }

            return account;
        }

        public Models.Account GetAccount(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Invalid username", nameof(username));
            }

            var account = _context.Accounts
                .Where(a => a.Username == username)
                .FirstOrDefault();

            if (account == null)
            {
                throw new ArgumentException("Account not found", nameof(username));
            }

            return account;
        }
    }
}
