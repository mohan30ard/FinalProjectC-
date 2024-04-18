using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class Transactions
    {
        public int TransactionID { get; set; }
        public int AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public Transactions(int transactionID, int accountNumber, string transactionType, decimal amount, string description)
        {
            TransactionID = transactionID;
            AccountNumber = accountNumber;
            TransactionType = transactionType;
            Amount = amount;
            Description = description;
        }
    }
}
