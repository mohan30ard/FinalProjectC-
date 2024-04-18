using phase_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.ServiceLayer.Impl
{
    public class AccountApprovalService : IAccountApprovalService
    {
        private readonly IAccountApprovalRepository _accountApprovalRepository;

        

        public void ApproveAccount(Models.Account account)
        {
            _accountApprovalRepository.ApproveAccount(account);
        }

        public List<Models.Account> GetPendingAccounts()
        {
            return _accountApprovalRepository.GetPendingAccounts();
        }
        public void RejectAccount(Models.Account account)
        {
            _accountApprovalRepository.RejectAccount(account);
        }
    }
}
