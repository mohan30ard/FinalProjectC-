using phase_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.Repositories.Impl
{
    public class AccountApprovalRepository : IAccountApprovalRepository
    {
        private readonly BankDBContext _context;

        public AccountApprovalRepository(BankDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void ApproveAccount(Models.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            // Update account status to approved
           // account.Status = AccountStatus.Approved;
            account.IsLocked = false; // Unlock the account

            // Save changes to the database
            _context.SaveChanges();
        }

        public List<Models.Account> GetPendingAccounts()
        {
            // Retrieve pending accounts
            //isLocked is true

            var pendingAccounts = _context.Accounts
                .Where(a => a.IsLocked == true)
                .ToList();

            return pendingAccounts;
        }

        

        public void RejectAccount(Models.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            // Update account status to rejected
           // account.Status = AccountStatus.Rejected;
            account.IsLocked = false; // Unlock the account

            // Save changes to the database
            _context.SaveChanges();
        }
    }
}
