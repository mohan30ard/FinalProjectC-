using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.Repositories
{
    public interface IAccountApprovalRepository
    {
        public void ApproveAccount(Models.Account account);
        public void RejectAccount(Models.Account account);
        public List<Models.Account> GetPendingAccounts();
    }
}
