using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LP_LAB04
{
    public class CollectionType<T> : IGeneric<T> where T : class 
    {
        
        public List<T> CollectionList = new List<T>();
        int count=0;
        public void Add(T item)
        {
            count++;
            if (!(item is T))
                throw new Exception("EXC");

            this.CollectionList.Add(item as T);
        }

        public void Delete(T item)
        {
            if (!(item is T))
                throw new Exception("EXC");
            this.CollectionList.Remove(item as T);
        }

        public void Show()
        {
            Flower el;
            foreach(T item in CollectionList)
            {
                el = item as Flower;
                Console.WriteLine(el.Name + ":" + el.Color);
            }

        }
        public void WriteData()
        {
            Flower el;
            using (StreamWriter sw = new StreamWriter("file.txt", false, System.Text.Encoding.Default))
            {
                foreach (T item in CollectionList)
                {
                    el = item as Flower;
                    sw.Write(el.Name + ":" + el.Color+":"+el.Col + "\n");
                }
            }
        }
        public void ReadData()
        {
            string str;
            using (StreamReader sw = new StreamReader("file.txt",System.Text.Encoding.Default))
            {
                while (!sw.EndOfStream)
                {
                    str = sw.ReadLine();
                    Console.WriteLine(str);
                }
            }
          
    }
        public int Count()
        {
            return count;
        }


    }

    public class Set<T>
    {
        public List<T> items { get; set; }
        public string id { get; set; } = "4";
        public string name { get; set; } = "Nikita";
        public string organization { get; set; } = "BSTU";
        public void Info()
        {
            Console.WriteLine($"ID: {id} \nИмя:{name}\nОрганизация:{organization}");
            Console.WriteLine("-------------------------------------------------------");

        }

        public Set(params Set<T>[] arr)
        {
            items = new List<T>();
            foreach (var my in arr)
            {
                items.AddRange(my.items);
            }
        }
        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            var resultSet = new Set<T>();


            foreach (var item in set1.items)
            {
                if (set2.items.Contains(item))
                {
                    resultSet.items.Add(item);
                }
            }


            return resultSet;
        }
        public static bool operator -(Set<T> set1, T item)
        {
            bool set;
            set = set1.items.Remove(item);
            return set;
        }
        public static bool operator <(Set<T> set1, Set<T> set2)
        {
            if (set1.items.Count < set2.items.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >(Set<T> set1, Set<T> set2)
        {
            bool flag = false;
            if (set1.items.Count > set2.items.Count)
            {

                foreach (var item in set2.items)
                {
                    if (set1.items.Contains(item))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else
            {
                foreach (var item in set1.items)
                {
                    if (set2.items.Contains(item))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Set<T> operator &(Set<T> set1, Set<T> set2)
        {
            var resultSet = new Set<T>();
            int i;
            for (i = 0; i < set1.items.Count; i++)
            {
                resultSet.items.Add(set1.items[i]);
            }
            foreach (var m in set2.items)
            {
                if (resultSet.items.Contains(m))
                {
                    continue;
                }
                else
                {
                    resultSet.items.Add(m);
                }
            }
            return resultSet;
        }



    }
    public static class StaticOperations
    {

        public static string Point(this string str)
        {
            string newStr = "";
            for (int i = 0; i <= str.Length; i++)
            {
                if (i == str.Length)
                {
                    newStr = str + '.';
                }
            }
            return newStr;

        }
        public static Set<int> DeleteNull(this Set<int> set1)
        {
            Set<int> result = new Set<int>();
            for (int i = 0; i < set1.items.Count; i++)
            {
                if (set1.items[i] == 0)
                {
                    continue;
                }

                else
                {
                    result.items.Add(set1.items[i]);
                }

            }
            return result;

        }
        public static int sum(this Set<int> set1)
        {
            int sum;
            sum = set1.items.Sum();
            return sum;

        }
        public static int diff(this Set<int> set1)
        {
            int max, min;
            max = set1.items.Max();
            min = set1.items.Min();
            return max - min;

        }
        public static int col(this Set<int> set1)
        {

            return set1.items.Count;

        }

    }

}
