using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpregadosOO.Entities
{
    internal class Address
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public Address() { }

        public Address(string email, string phone)
        {
            Email = email;
            Phone = phone;

        }
    }
}
