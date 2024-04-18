using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public long SSN { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // For simplicity; in a real-world scenario, passwords should be securely hashed and salted
        public decimal Balance { get; set; }

        public bool IsLocked { get; set; }

        //constructor to create a new account with all the details including phone number and SSN
        public Account(int accountNumber, string name, string address, string email, string phoneNumber, long ssn, string username, string password, decimal balance)
        {
            AccountNumber = accountNumber;
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            SSN = ssn;
            Username = username;
            Password = password;
            Balance = balance;
            IsLocked = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Account Number: " + AccountNumber);
            sb.AppendLine("Name: " + Name);
            sb.AppendLine("Address: " + Address);
            sb.AppendLine("Email: " + Email);
            sb.AppendLine("Phone Number: " + PhoneNumber);
            sb.AppendLine("SSN: " + SSN);
            sb.AppendLine("Username: " + Username);
            sb.AppendLine("Balance: " + Balance);
            sb.AppendLine("Is Locked: " + IsLocked);
            
            return sb.ToString();
        }

    }
}
