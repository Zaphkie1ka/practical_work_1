using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private List<User> users = new List<User>();
        private List<Request> requests = new List<Request>();
        private List<Instruments> instruments = new List<Instruments>();
        private User currentUser;

        static void Main(string[] args)
        {
            User user = new User("Nikita", "Zaphkie1", "ne_skazhu");
        }
        public void addUser(string name, string login, string password, string repeation, int type)
        {
            users.Add(new User(name, login, password));
        }
        public User findUser(string login, string password)
        {

            return (User)users.Where(k => k.enter(login, password));
        }
    }
}
