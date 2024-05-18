using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Klient
    {
    public string Login { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }
        public decimal Punkty { get; set; }

        public Klient(string login, string haslo, string email)
        {
            Login = login;
            Haslo = haslo;
            Email = email;
            Punkty = 0;
        }
    }

}

