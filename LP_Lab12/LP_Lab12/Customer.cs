using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Lab12
{
    class Customer : ICloneable
    {


        public int id { get; private set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middleName { get; set; }
        public string address { get; set; }
        public int credit_card_number { get; set; }
        public int balance { get; set; }
        public const int an = 50;
        protected static readonly DateTime globalStartTime;
        static int count = 0;
        public Customer() { count++; id = 15; surname = "Lipov"; name = "Anton"; middleName = "Pavlovich"; address = "Michailova 41"; credit_card_number = 4567; balance = 500; }
        public Customer(int a, string b, string c, string d, string e, int f, int g)
        {
            count++;
            this.id = a;
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
        public int bal(int number)
        {
            int oleg=0;
            oleg += number;
            return oleg;
        }
        public void sum_from_balance()
        {
            Console.Write("Введите сумму списания со счета:");
            int sum = Convert.ToInt32(Console.ReadLine());
            balance = balance - sum;
            if (balance < 0)
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
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
