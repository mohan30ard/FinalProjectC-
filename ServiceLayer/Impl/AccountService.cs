using phase_1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1.ServiceLayer.Impl
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountApprovalRepository _accountApprovalRepository;
        private static readonly Random random = new Random();
        private static List<int> generatedAccountNumbers = new List<int>();
        

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository ?? throw new ArgumentNullException(nameof(accountRepository));
        }

        public void CreateAccount(Models.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }
            

            _accountRepository.CreateAccount(account);
           // _accountApprovalRepository.ApproveAccount(account);

        }

        public void UpdateAccount(Models.Account account)
        {
            if (account == null)
            {
                throw new ArgumentNullException(nameof(account));
            }

            _accountRepository.UpdateAccount(account);
        }

        public void DeleteAccount(int accountNumber)
        {
            _accountRepository.DeleteAccount(accountNumber);
        }

        public Models.Account GetAccount(int accountNumber)
        {
            return _accountRepository.GetAccount(accountNumber);
        }

        public List<Models.Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public int GenerateAccountNumber()
        {
            int newAccountNumber;
            do
            {
                newAccountNumber = random.Next(1000000, 10000000);
            } while (generatedAccountNumbers.Contains(newAccountNumber));

            generatedAccountNumbers.Add(newAccountNumber);
            return newAccountNumber;
        }

        public string GenerateUserName(string name, string phoneNumber)
        {
            string namePart = name.Substring(0, Math.Min(name.Length, 4));

            string phoneNumberString = phoneNumber.ToString();

            string phoneNumberPart = phoneNumberString.Substring(0, Math.Min(phoneNumberString.Length, 4));

            if (namePart.Length < 4)
            {
                namePart = namePart.PadRight(4, '0');
            }

            string username = namePart + "_" + phoneNumberPart;

            return username;
        }

        public Models.Account GetAccount(string username)
        {
            return _accountRepository.GetAccount(username);
        }

        public string AddtoListBox(Models.Account account)
        {

            return "Name : " + account.Name.ToString() + " - " + "Account Number : " + account.AccountNumber.ToString() + " - " + "User Name : " + account.Username.ToString() + " - " + "Locked : " + account.IsLocked.ToString();
        }

    }
}
