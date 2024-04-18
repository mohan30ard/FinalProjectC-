using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.ServiceLayer
{
    public interface IAccountApprovalService
    {
        void ApproveAccount(Models.Account account);
        List<Models.Account> GetPendingAccounts();
        void RejectAccount(Models.Account account);
    }
}
