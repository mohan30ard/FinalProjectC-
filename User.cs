using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase_1
{
    public class User
    {
        public int UserId { get; }
        public string Username { get; }

        public User(int userId, string username)
        {
            UserId = userId;
            Username = username;
        }
    }

}
