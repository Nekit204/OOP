using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB05
{
    struct Flowers
    {
        public string name;
        public string color;
        public int price;

        public Flowers(string Name, string Color, int Price)
        {
            name = Name;
            color = Color;
            price = Price;
        }

    }
    partial class Bouque
    {
        private Flowers rose = new Flowers("Роза", "красный", 150);
        private Flowers rose2 = new Flowers("Роза", "белый", 175);
        private Flowers gladiolus = new Flowers("Гладиолус", "розовый", 100);
        private Flowers chamomile = new Flowers("Ромашка", "белый", 50);
        public enum Enum { rose = 1, rose2, gladiolus, chamomile }
        private List<object> flowers = new List<object>();

        public List<object> ListofFlowers     
        {
            get => flowers;
        }

        public void Add(Flower flowr)     
        {
            object obj = flowr;
            ListofFlowers.Add(obj);
        }

        public bool Remove(int index)
        {
            if (ListofFlowers.Count < index)
                return false;
            Console.WriteLine($"элемент [{index}] удален.");
            ListofFlowers.RemoveAt(index);
            return true;
        }

        public void Show()
        {

            Console.WriteLine("-------Элементы списка--------");

            foreach (var i in ListofFlowers)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("------------------------------");

        }



    }
    class BouqueController
    {
        public string Name { get; set; }

        public static object ReturnFlower(Bouque bouque, string color)
        {

            object[] arr = bouque.ListofFlowers.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"---------------Цветов цвета {color}----------");
                }
                if (arr[i] is Rose)
                {
                    Rose rose = arr[i] as Rose;
                    if (rose.Color == color)
                        Console.WriteLine(arr[i]);
                    continue;
                }
                else if (arr[i] is Gladiolus)
                {
                    Gladiolus gladiolus = arr[i] as Gladiolus;
                    if (gladiolus.Color == color)
                        Console.WriteLine(arr[i]);
                    continue;
                }
                else if (arr[i] is Chamomile)
                {
                    Chamomile cham = arr[i] as Chamomile;
                    if (cham.Color == color)
                        Console.WriteLine(arr[i]);
                    continue;
                }
            }
            return 0;
        }
        public static void Sorted(Bouque bouque)
        {
            int result = 0;
            Flower fhelper=new Flower("","",0);
            object[] arr = bouque.ListofFlowers.ToArray();
            Flower[] flowers = new Flower[100];
            for (int i = 0; i < arr.Length; i++)
            {
                Flower flow = arr[i] as Flower;
                flowers[i] = flow;
            }

            for (int i = 0; i < flowers.Count(); i++)
            {
                if (flowers[i + 1] != null)
                {
                    result = String.Compare(flowers[i].Name, flowers[i + 1].Name);

                    if (result < 0)
                    {
                        flowers[i] = flowers[i];
                    }
                    else if (result > 0)
                    {
                        fhelper = flowers[i];
                        flowers[i] = flowers[i + 1];
                        flowers[i + 1] = fhelper;
                    }
                }
                else
                {
                    flowers[i] = flowers[i];
                }
                if (flowers[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(flowers[i]);
                    
                }
            }
           
            
        }
        public static int FindSum(Bouque bouque) // Розы=100,Гладиолус=75,Ромашка=50
        {
            int sum=0;
            object[] arr = bouque.ListofFlowers.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Rose)
                {
                    Rose rose = arr[i] as Rose;
                    sum += rose.Col * 100;
                }
                if (arr[i] is Gladiolus)
                {
                    Gladiolus glad = arr[i] as Gladiolus;
                    sum += glad.Col * 75;
                }
                if (arr[i] is Chamomile)
                {
                    Chamomile cham = arr[i] as Chamomile;
                    sum += cham.Col * 50;
                }
            }
            return sum;
        }
        public static void WriteInfo(Bouque bouque)
        {
            using (FileStream fs = new FileStream("test.txt", FileMode.Open))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.Default))
                {
                    object[] arr = bouque.ListofFlowers.ToArray();
                    Flower[] flowers = new Flower[100];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Flower flow = arr[i] as Flower;
                        flowers[i] = flow;
                    }
                    for (int i = 0; i < flowers.Count(); i++)
                    {
                        if (flowers[i] == null)
                        {
                            break;
                        }
                        else
                        {
                            w.Write(flowers[i].Name + "," + flowers[i].Color + "," + flowers[i].Col + ".\n");
                        }
                    }
                }
            }

        }
        public static void ReadInfo(Bouque bouque)
        {
            
            string str;
            FileStream fs = new FileStream("test.txt", FileMode.Open);
            StreamReader w = new StreamReader(fs, Encoding.Default);
            Flower[] flowers = new Flower[100];
            while(!w.EndOfStream)
            {
                str = w.ReadLine();
                Console.WriteLine(str);

            }
            w.Close();
            
        }

    }
}
