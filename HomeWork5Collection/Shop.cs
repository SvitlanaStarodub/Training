using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5Collection
{
    public class Shop
    {
        private Dictionary<string, string> _authorizedUsers;
        private Dictionary<string, int> _items;
        private Dictionary<string, int> _order;

        public List<string> getUsers()
        {
            return _authorizedUsers.Keys.ToList();
        }


        public Shop(Dictionary<string, string> authorizedUsers, Dictionary<string, int> items)
        {
            _authorizedUsers = new Dictionary<string, string>();
            foreach (var user in authorizedUsers)
            {
                _authorizedUsers.Add(user.Key, user.Value);
            }
            _items = items;

        }

        public void AddClient(string userName, string password)
        {

            _authorizedUsers.Add(userName, password);
        }


        public bool Login(string userName, string password)
        {
            if (_authorizedUsers.ContainsKey(userName) && _authorizedUsers[userName] == password)
                return true;

            return false;
        }

        public bool OrderStuff(string stuff, int amount)
        {
            if (_items.ContainsKey(stuff) && _items[stuff] >= amount)


                return true;
            return false;
        }

       


    }
}

