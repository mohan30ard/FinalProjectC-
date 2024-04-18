using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class TransactionManager
    {
        private TransactionDB transactionDB;

        public TransactionManager(TransactionDB transactionDB)
        {
            this.transactionDB = transactionDB;
        }

        public void AddTransaction(Transaction transaction)
        {
            transactionDB.SaveTransaction(transaction);
        }

        public List<Transaction> GetTransactions()
        {
            return transactionDB.GetTransactions();
        }
    }
}
