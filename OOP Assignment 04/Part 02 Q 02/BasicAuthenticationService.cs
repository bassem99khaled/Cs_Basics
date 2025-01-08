using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_04.Part_02_Q_02
{
    class BasicAuthenticationService : IAuthenticationService
    {
         readonly Dictionary<string, (string Password, List<string> Roles)> _users;

        public BasicAuthenticationService()
        {
           
            _users = new Dictionary<string, (string Password, List<string> Roles)>
        {
            { "admin", ("admin123", new List<string> { "Admin", "User" }) },
            { "user", ("user123", new List<string> { "User" }) }
        };
        }

        public bool AuthenticateUser(string username, string password)
        {
            if (_users.ContainsKey(username) && _users[username].Password == password)
            {
                Console.WriteLine($"User '{username}' authenticated successfully.");
                return true;
            }

            Console.WriteLine($"Authentication failed for user '{username}'.");
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (_users.ContainsKey(username) && _users[username].Roles.Contains(role))
            {
                Console.WriteLine($"User '{username}' is authorized for the role '{role}'.");
                return true;
            }

            Console.WriteLine($"User '{username}' isn't authorized for the role '{role}'.");
            return false;
        }

        }
    }