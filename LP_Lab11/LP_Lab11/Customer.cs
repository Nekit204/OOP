using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Lab11
{
    class Customer
    {
        public int id { get; private set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string address { get; set; }
        public int credit_card_number { get; set; }
        public int balance { get; set; }
        public Customer(int a, string b, string c, string d, string e, int f, int g)
        {
            this.id = a;
            this.surname = b;
            this.name = c;
            this.middleName = d;
            this.address = e;
            this.credit_card_number = f;
            this.balance = g;
        }
    }
}
