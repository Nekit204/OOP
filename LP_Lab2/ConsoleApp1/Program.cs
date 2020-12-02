using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a=true;
            byte bit = 1;
            sbyte sbit = -1;
            short shrt = -3;
            ushort ushrt = 3;
            int b = 10;
            long l = -500;
            ulong ul = 500;
            float fl = 0.34F;
            double dl = 3.1678;
            decimal dc = 34;
            char word = 'W';
            string aleg = "Aleg";
            object obj = 456;
            Console.WriteLine("--------------First Task------------");
            Console.WriteLine("a)");
            Console.WriteLine($"bool:{a}");
            Console.WriteLine($"byte:{bit}");
            Console.WriteLine($"sbyte:{sbit}");
            Console.WriteLine($"short:{shrt}");
            Console.WriteLine($"bool:{ushrt}");
            Console.WriteLine($"int:{b}");
            Console.WriteLine($"long:{l}");
            Console.WriteLine($"ulong:{ul}");
            Console.WriteLine($"float:{fl}");
            Console.WriteLine($"double:{dl}");
            Console.WriteLine($"decimal:{dc}");
            Console.WriteLine($"char:{word}");
            Console.WriteLine($"string:{aleg}");
            Console.WriteLine($"object:{obj}");
            int ti = 5;
            double x = ti;
            float t = ti;
            long ln = ti;
            object o = ti;
            decimal n = ti;
            int tk = 5;
            double x2 = (double)tk;
            float t2 = (float)tk;
            long ln2 = (long)tk;
            object o2 = (object)tk;
            decimal n2 = (decimal)tk;
            Console.WriteLine("b)");
            Console.WriteLine("Неявное преобразование:");
            Console.WriteLine($"double:{x};float:{t};long:{ln};object:{o};decimal:{n};");
            Console.WriteLine("Явное преобразование:");
            Console.WriteLine($"double:{x2};float:{t2};long:{ln2};object:{o2};decimal:{n2};");
            Console.WriteLine("c)");
            int m = 6;
            object box = m;
            int unboxed = (int)m;
            Console.WriteLine("d)");
            var i = 12.3;
            Console.WriteLine($"var:{i};");
            Console.WriteLine("e)");
            Nullable<int> r54 = 54;
            Console.Write($"Свойство HasValue:");
            Console.WriteLine(r54.HasValue);
            int? r32 = 32;
            Console.Write($"Свойство Value:");
            Console.WriteLine(r32.Value);
            Console.WriteLine("f)");
            //var kl = 32;
            //double v;
            //kl=v;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------------Second Task------------");
            Console.WriteLine("a)");
            string str1 = "Welcome home";
            string str2 = " good ";
            string str3 = "hunter";
            int result = String.Compare(str1, str2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            Console.WriteLine("b)");
            string str4 = String.Concat(str1, str2, str3);
            Console.WriteLine($"Конкатенация:{ str4}");
            string str5 = String.Copy(str3);
            //string str5 = str2;
            Console.WriteLine($"Копирование:{ str5}");
            string str6 = str4.Substring(17);
            Console.WriteLine($"Выделение подстроки:{str6}");
            Console.WriteLine("Разбиение строки на слова:");
            string[] words = str4.Split(new char[] { ' ' });
            foreach(string str7 in words)
            {
                Console.WriteLine(str7);
            }
            str1 = str1.Insert(8, str2);
            Console.WriteLine($"Вставка подстроки:{str1}");
            str1 = str1.Remove(7, 6);
            Console.WriteLine($"Удаление подстроки:{str1}");
            Console.WriteLine("d)");
            string str8 = "";
            string str9 = null;
            Console.Write("IsNullOrEmpty:");
            Console.Write(String.IsNullOrEmpty(str8));
            Console.Write(",");
            Console.Write(String.IsNullOrEmpty(str9));
            Console.Write(",");
            Console.WriteLine(String.IsNullOrEmpty(str2));
            Console.WriteLine("e)");
            StringBuilder str11 = new StringBuilder("For Mula");
            Console.WriteLine($"StringBuilder:{str11}");
            str11.Remove(0, 3);
            str11.Insert(0, "=)");
            str11.Append(" (=");
            Console.Write("После преобразований: ");
            Console.WriteLine(str11);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------------Third Task------------");
            Console.WriteLine("a)Матрица:");
            int[,] mas1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int rows = mas1.GetUpperBound(0) + 1;
            int columns = mas1.GetUpperBound(1) + 1;
            for (int  z= 0; z < rows; z++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas1[z, j]} \t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("b)");
            string[] names = { "Oleg", "Anton", "Artem", "Misha", "Sasha" };
            int length = names.Length;
            Console.Write("Массив строк:");
            for (int cil = 0; cil < length; cil++)
            {
                Console.Write(names[cil]);
                if (cil != 4)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.Write(";");
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Длина:{length}");
            names[2] = "Masha";
            Console.Write("Замена второго элемента:");
            for (int cil = 0; cil < length; cil++)
            {
                Console.Write(names[cil]);
                if (cil != 4)
                {
                    Console.Write(",");
                }
                else
                {
                    Console.Write(";");
                }

            }
            Console.WriteLine();
            Console.WriteLine("c)");
           
            int[][] mas3 = new int[3][];
            mas3[0] = new int[2];
            mas3[1] = new int[3];
            mas3[2] = new int[4];
            Console.WriteLine("Введите числа:");
            for (int cl=0; cl < 2; cl++)
            {
                mas3[0][cl] = Convert.ToInt32(Console.ReadLine());
                
            }
            for (int cl2=0; cl2 < 3; cl2++)
            {
                mas3[1][cl2] = Convert.ToInt32(Console.ReadLine());

            }
            for (int cl3=0; cl3 < 4; cl3++)
            {
                mas3[2][cl3] = Convert.ToInt32(Console.ReadLine());

            }
            for (int nm=0; nm < 2; nm++)
            {
                Console.Write(mas3[0][nm]+"\t");
            }
            Console.WriteLine();
            for (int nm2=0; nm2 < 3; nm2++)
            {
                Console.Write(mas3[1][nm2]+"\t");
            }
            Console.WriteLine();
            for (int nm3=0; nm3 < 4; nm3++)
            {
                Console.Write(mas3[2][nm3]+"\t");
            }
            Console.WriteLine();
            Console.WriteLine("d)");
            var mas54 = new[] { 1, 5, 67, 81, 4, 5 };
            var str15 = "Почему так часто пропадаешь?";
            Console.Write("Массив: ");
            for(int lim=0;lim<mas54.Length;lim++)
            {
                Console.Write(mas54[lim] + "\t");
            }
            Console.WriteLine();
            Console.Write($"Строка:{str15}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------------Fourth Task------------");
            Console.WriteLine("a)");
            Console.WriteLine("b)");
            (int, string, char, string, ulong) tuple = (5, "Geka", 'f', "Artem", 167);
            Console.WriteLine("Кортеж:" + tuple.Item1 + "," + tuple.Item2 + "," + tuple.Item3 + "," + tuple.Item4 + "," + tuple.Item5 + ";");
            Console.WriteLine("Элемент 1:" + tuple.Item1);
            Console.WriteLine("Элемент 3:" + tuple.Item3);
            Console.WriteLine("Элемент 4:" + tuple.Item4);
            int nei;
            string ei;
            char ik;
            string ei2;
            ulong nik;
            (nei, ei, ik, ei2, nik) = tuple;
            Console.WriteLine($"Unboxing:({nei},{ei},{ik},{ei2},{nik})");
            (int, string, char,string, ulong ) PrintTouple((int abbb, string bbbbb, char cbbbb,string s1, ulong uuuu)tpl)
            {
                return tpl;
            }
            (nei, ei, ik, ei2,_) = PrintTouple(tuple);
            (int, string, char, string, ulong) tuple2 = (15, "Aleg", 'v', "Giga", 257);
            Console.Write("Сравнение двух кортежей:");
            Console.Write(tuple == tuple2);
            Console.Write(",");
            Console.WriteLine(tuple.CompareTo(tuple2));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------------Fifth Task------------");
            Tuple<int, int, int, char> TestFunc(int[] arr, string funcString)
            {
                return new Tuple<int, int, int, char>(arr.Max(), arr.Min(), arr.Sum(), funcString[0]);
            }

            var intArr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var funcStr = "abcd";

            var testFuncTuple = Tuple.Create(TestFunc(intArr, funcStr));
            Console.WriteLine(testFuncTuple);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("--------------Sixth Task------------");
            /*void checkedTest()
            {
                checked
                {
                    var left = int.MaxValue + 1;
                }
            }*/

            void uncheckedTest()
            {
                unchecked
                {
                    var left = int.MaxValue + 1;
                    Console.WriteLine(left);
                }
            }

            /*checkedTest();*/

            uncheckedTest();
        }


    }
}
