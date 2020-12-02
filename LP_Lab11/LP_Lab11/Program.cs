using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string[] monthes = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] key = { 7, 8, 5, 3, 4, 6, 9};
            Console.WriteLine("Введите длину строки:");
            n = Convert.ToInt32(Console.ReadLine());
            IEnumerable<string> result1 = from m in monthes where  m.Length == n select m;
            foreach(string l in result1)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("-------------------------------------------------------");
            IEnumerable<string> result2 = from m in monthes where String.Equals(m,"August")||String.Equals(m,"June")||String.Equals(m, "July") || String.Equals(m, "December")||String.Equals(m, "January") || String.Equals(m, "February")  select m;
            foreach (string l in result2)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("-------------------------------------------------------");
            IEnumerable<string> result3 = from m in monthes orderby m select m;
            foreach (string l in result3)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("-------------------------------------------------------");
            IEnumerable<string> result4 = from m in monthes where m.Length>=4 && m.Contains("u") select m;
            foreach (string l in result4)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("______________________________________________________________________________");
            List<Customer> Collections_of_customers = new List<Customer>();
            Customer customer1 = new Customer(15, "Pavlov", "Oleg", "Aleksandrovich", "Piletskogo str", 5470, 1500);
            Customer customer2 = new Customer(21,  "Gushin", "Michail", "Pavlovich", "Serova str", 1980, 2678);
            Customer customer3 = new Customer(33,  "Mishustin", "Aleksey", "Semenovich","Sverdlova str", 2567, 110000);
            Customer customer4 = new Customer(46,  "Plyut", "Aleksandr", "Petrovich","Lipina str" ,3154, 16783);
            Customer customer5 = new Customer(9, "Nikonov", "Pavel", "Igorevich","Mashino str", 1723, 9871);
            Customer customer6 = new Customer(91, "Belov", "Nazar", "Michailovich","Poleskino str", 9110, 17654);
            Customer customer7 = new Customer(73,  "Chernov", "Vadim", "Fedorovich","Stoletova str", 7456, 7421);
            Customer customer8 = new Customer(4,  "Lobin", "Trofim", "Kirillovich", "Libino str",8791, 323);
            Collections_of_customers.Add(customer1);
            Collections_of_customers.Add(customer2);
            Collections_of_customers.Add(customer3);
            Collections_of_customers.Add(customer4);
            Collections_of_customers.Add(customer5);
            Collections_of_customers.Add(customer6);
            Collections_of_customers.Add(customer7);
            Collections_of_customers.Add(customer8);
            IEnumerable<Customer> result5 = from cust in Collections_of_customers orderby cust.name select cust;
            foreach(Customer c in result5)
            {
                Console.WriteLine(c.name);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            IEnumerable<Customer> result6 = from cust in Collections_of_customers where cust.credit_card_number<5000&&cust.credit_card_number>2000 select cust;
            foreach (Customer c in result6)
            {
                Console.WriteLine(c.name+"-"+c.credit_card_number);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            int max = Collections_of_customers.Max(z => z.balance);
            IEnumerable<Customer> result7 = from cust in Collections_of_customers where cust.balance == max select cust;
            foreach (Customer c in result7)
            {
                Console.WriteLine(c.name + "-" + c.balance);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            IEnumerable<Customer> result8 = from cust in Collections_of_customers orderby cust.balance descending select cust;
            int count = 0;
            foreach (Customer c in result8)
            {
                while (count != 5)
                {
                    count++;
                    Console.WriteLine(c.name + "-" + c.balance);
                    break;
                }
            }
            Console.WriteLine("--------------------------------------------------------------------");
            var result9 = monthes.TakeWhile(m => !m.SequenceEqual("September"))
                                 .Intersect(monthes.Skip(3))
                                 .Concat(monthes.Take(1))
                                 .OrderByDescending(z => z)
                                 .SkipWhile(z => z.Length < 6)
                                 .GroupBy(z => z.Length)
                                 .Max(z => z.Count());
            Console.WriteLine(result9);
            Console.WriteLine("--------------------------------------------------------------------");
            var result10 = monthes
                .Join(key,
                      w => w.Length,
                      q => q,
                      (w, q) => new
                      {
                          id = q,
                          month = String.Format("{0}", w),
                      });
            foreach(var item in result10)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
