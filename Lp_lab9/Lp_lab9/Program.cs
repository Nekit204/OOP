using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_lab9
{
    public delegate void Fine(string mes, int sum);
    public delegate void Increase();
    class Program
    {
        private static void Main(string[] args)
        {
            string MessageAboutIncrease;
            int Sum_of_increase;
            Director director = new Director();
            PartTimeStudent students = new PartTimeStudent();
            Turner turners = new Turner();
            director.inc += students.GetNewInfo;
            director.inc += turners.GetNewInfo;
            director.fn += turners.GetNewInfo;
            director.Raise();
            Console.WriteLine("Напишите причину штрафа:");
            MessageAboutIncrease = Console.ReadLine();
            Console.WriteLine("Сумма штрафа:");
            Sum_of_increase = Convert.ToInt32(Console.ReadLine());
            director.Give_a_fine(MessageAboutIncrease, Sum_of_increase);
            Console.WriteLine("\n------------------------Строки---------------------\n");
            Func<string, string> A;
            string str = ("mKlCV      Btre!?cn        d;mx:        NMV.");
            Console.WriteLine($"Исходная строка:{str}");
            A = Methods_for_String.RemoveS;
            Console.WriteLine($"Без знаков препинания:{str = A(str)}");
            A = Methods_for_String.RemoveSpase;
            Console.WriteLine($"Без пробелов:{str = A(str)}");
            A = Methods_for_String.Upper;
            Console.WriteLine($"Заглавными буквами:{str = A(str)}");
            A = Methods_for_String.Lower;
            Console.WriteLine($"Строчными буквами:{str = A(str)}");
            A = Methods_for_String.AddToString;
            Console.WriteLine($"С добавлением символа:{str = A(str)}");
            Console.ReadKey();
        }
    }
}
