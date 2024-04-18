using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class Transaction
    {
        public static int TransactionID = 1;
        public int AccountNumber { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        public Transaction( int accountNumber, string transactionType, decimal amount, DateTime transactionDate)
        {
            TransactionID++;
            AccountNumber = accountNumber;
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Transaction ID: " + TransactionID);
            sb.AppendLine("Account Number: " + AccountNumber);
            sb.AppendLine("Transaction Type: " + TransactionType);
            sb.AppendLine("Amount: " + Amount);
            sb.AppendLine("Transaction Date: " + TransactionDate);
            return sb.ToString();
        }
    }
}
