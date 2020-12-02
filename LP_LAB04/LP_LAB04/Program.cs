using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();

                Set<string> Nekit = new Set<string>();
                Console.WriteLine("--------------------Owner--------------");
                Nekit.Info();
                CollectionType<Flower> flower = new CollectionType<Flower>();
                Flower rose1 = new Flower("rose", "black", 2);
                Flower rose2= new Flower("rose", "white", 4);
                Flower rose3 = new Flower("rose", "red", 6);
                flower.Add(rose1);
                flower.Add(rose2);
                flower.Add(rose3);
                Console.WriteLine("---------------------------Before delete--------------------------");
                flower.Show();
                Console.WriteLine("-----------------------------------------------------------------------");
                flower.Delete(rose2);
                Console.WriteLine("---------------------------After delete--------------------------");
                flower.Show();
                Console.WriteLine("-----------------------------------------------------------------------");
                flower.WriteData();
                flower.ReadData();
                Set<int> set1 = new Set<int>();
                set1.items.Add(1);
                set1.items.Add(2);
                set1.items.Add(3);
                set1.items.Add(4);
                set1.items.Add(5);
                Set<int> set2 = new Set<int>();
                set2.items.Add(1);
                set2.items.Add(2);
                set2.items.Add(3);
                Set<int> set3 = new Set<int>();
                set3.items.Add(1);
                set3.items.Add(0);
                set3.items.Add(3);
                bool tr, tp, tk;
                int it = 5;
                Set<int> result = new Set<int>();
                Console.WriteLine("--------------Множество 1-------------");

                for (int i = 0; i < 5; i++)
                {
                    Console.Write(set1.items[i]);
                    if (i != 4)
                    {
                        Console.Write(',');
                    }

                }
                tr = set1 - it;
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Возвращаемое значение Remove:" + tr);
                Console.WriteLine("--------------Множество 1(после удаления элемента)-------------");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(set1.items[i]);
                    if (i != 3)
                    {
                        Console.Write(',');
                    }

                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("--------------Результат пересечения множеств set1 и set2-------------");
                result = set1 * set2;
                Console.WriteLine();
                for (int i = 0; i < result.items.Count; i++)
                {
                    Console.WriteLine(result.items[i]);
                }
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("--------------Сравнение множеств------------");
                tp = set1 < set2;
                Console.WriteLine(tp);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("--------------Проверка на подмножество------------");
                tk = set1 > set2;
                Console.WriteLine(tk);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("--------------Результат объединения------------");
                result = set2 & set1;
                Console.WriteLine();
                for (int i = 0; i < result.items.Count; i++)
                {
                    Console.WriteLine(result.items[i]);
                }
                Console.WriteLine("-------------------------------------");
                string str = "";
                string str2 = "";
                for (int i = 0; i < set1.items.Count; i++)
                {
                    str = Convert.ToString(set1.items[i]);
                    str2 = str2 + str;
                }
                str2 = str2.Point();
                Console.WriteLine("-------------Метод Point------------");
                Console.WriteLine(str2);
                Console.WriteLine("-------------------------------------");
                set3 = set3.DeleteNull();
                Console.WriteLine("-------------Метод DeleteNull------------");
                for (int count = 0; count < set3.items.Count; count++)
                {
                    Console.WriteLine(set3.items[count]);
                }
                Console.WriteLine("-------------------------------------\n");
                int sum, diff, col;
                Console.WriteLine("----------------Методы суммы,разности максимального и минимального,количество элементов---------------------\n");
                sum = set1.sum();
                diff = set1.diff();
                col = set1.col();
                Console.WriteLine("Сумма=" + sum + ";" + "Разница=" + diff + ";" + "Количество=" + col + ";");
                Console.WriteLine("-------------------------------------");
                Console.ReadKey(true);
            }
            catch
            {

            }
        }
    }
}
