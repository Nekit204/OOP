using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB03
{
    class Customer
    {

        public int id { get; private set;}
        public string surname { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string address { get; set; }
        public int credit_card_number { get; set; }
        public int balance { get; set; }
        public const int an= 50;
        protected static readonly DateTime globalStartTime;
        static int count=0;
        public Customer() { count++; id = 15; surname = "Lipov"; name = "Anton"; middleName = "Pavlovich"; address = "Michailova 41"; credit_card_number = 4567; balance = 500; }
        public Customer(int a, string b, string c, string d, string e, int f, int g) 
        {
        count++;
        this.id=a;
        this.surname = b;
        this.name = c;
        this.middleName = d;
        this.address = e;
        this.credit_card_number = f;
        this.balance = g;
        }
             
        public override string ToString()
        {
            return $"{id},{name},{surname},{address},{credit_card_number},{balance}";
        }
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
        public void sum_on_balance()
        {
            Console.Write("Введите сумму поступления на счет:");
            int sum = Convert.ToInt32(Console.ReadLine());
            balance = balance + sum;
        }
        public void sum_from_balance()
        {
            Console.Write("Введите сумму списания со счета:");
            int sum = Convert.ToInt32(Console.ReadLine());
            balance = balance - sum;
            if (balance<0)
            {
                throw new Exception("Недостаточно средств на счете.");
            }
        }
        public void Info()
        {
            Console.WriteLine($" ID: {id} \n Фамилия: {surname} \n Имя:{name}\n Отчество:{middleName}\n Адрес:{address}\n Номер карты:{credit_card_number}\n Баланс:{balance}");
            Console.WriteLine("-------------------------------------------------------");
            
        }
        public static void Count(ref int x)
        {
            Console.WriteLine("Счетчик:" + count);
            x = count;
        }
       
        static Customer()
        {
            globalStartTime = DateTime.Now;
            Console.WriteLine("Статический конструктор:{0}",
                globalStartTime.ToLongTimeString());
           
        }
      
    }
    public partial class Cust
    {
       
        public void Begin()
        {
            Console.WriteLine("Begin.");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer Anton = new Customer();
            Customer Ivan = new Customer(18, "Michov","Ivan","Sergeevich","Levkina 31",5678,700);
            var Oleg = new { V = 31, T="Lichov", C="Oleg", S="Sergeevich", H="Levkina 51", G=8878, O=900 };
            Anton.Info();
            Ivan.Info();
            Ivan.sum_on_balance();
            Ivan.Info();
            Anton.sum_from_balance();
            Anton.Info();
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(21, "Malikov", "Igor", "Igorevich", "Leskino 21", 3450, 200));
            customers.Add(new Customer(22, "Aalikov", "Alexey", "Sergeevich", "Lipkino 31", 8678, 1400));
            customers.Add(new Customer(23, "Balikov", "Alexander", "Petrovich", "Lenina 41", 4678, 300));

            
            List<string> stl = new List<string>();
            foreach (Customer srnm in customers)
            {
                stl.Add(srnm.surname);
            }
            stl.Sort();
            Console.WriteLine("Алфавитный порядок:");
            foreach (string g in stl)
            {
                foreach (Customer srnm in customers)
                {
                    if (g == srnm.surname)
                    {
                        Console.WriteLine(srnm.id + " " + srnm.surname + " " + srnm.name + " " + srnm.middleName+" "+ srnm.address+" "+ srnm.credit_card_number+" "+srnm.balance);
                    }
                }
            }
            Console.WriteLine("Диапазон:");
            foreach (Customer numb in customers)
                {
                    if (numb.credit_card_number<5000 && numb.credit_card_number>1000)
                    {
                        Console.WriteLine(numb.id + " " + numb.surname + " " + numb.name + " " + numb.middleName + " " + numb.address + " " + numb.credit_card_number + " " + numb.balance);
                    }
                }
            int x=0;
            Customer.Count(ref x);
            Console.WriteLine("Счётчик:"+x);
            Console.WriteLine("Метод ToString:"+Anton.ToString());
            Console.WriteLine("Hash-code:"+Anton.GetHashCode());
            Console.WriteLine("GetType:" + Anton.GetType());
            bool yen = Anton.Equals(Ivan);
            Console.WriteLine("Equals:" + yen);
            Console.WriteLine("Anonym:" + Oleg.GetType());
            Cust c = new Cust();
            c.Begin();
            c.TheEnd();
            Console.ReadKey(true);
        }
    }
}
