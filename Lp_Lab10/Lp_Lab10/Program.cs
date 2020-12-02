using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
namespace Lp_Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag=false;
            bool flag2 = false;
            int key, key2;
            int n;
            Worker oleg = new Worker("Олег", "администратор");
            Worker pavel = new Worker("Павел", "менеджер по продажам");
            Worker dasha = new Worker("Даша", "директор");
            Hashtable workers = new Hashtable();
            workers.Add(1,oleg);
            workers.Add(2, pavel);
            workers.Add(3, dasha);
            ICollection keys = workers.Keys;
            Console.WriteLine("-----------------------Элементы HashTable-------------------------- ");
            foreach(int i in keys)
            {
                Worker w = workers[i] as Worker;
                Console.WriteLine(i+ ": " + w.Name+"-"+w.Profession);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-----------------------Поиск по ключу-------------------------- ");
            Console.WriteLine("Введте ключ:");
           key=Convert.ToInt32(Console.ReadLine());
           foreach(int k in keys)
            {
               
                if (key==k)
                {
                    Worker wr = workers[k] as Worker;
                    Console.WriteLine(k + ": " + wr.Name + "-" + wr.Profession);
                    flag = true;
                }
                
            }
           if(!flag)
            {
                Console.WriteLine("Key not found");
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("----------------------------Удаление элемента по ключу---------------");
            workers.Remove(2);
            foreach (int i in keys)
            {
                Worker w = workers[i] as Worker;
                Console.WriteLine(i + ": " + w.Name + "-" + w.Profession);
            }
            Console.WriteLine("--------------------------------------------------------------------");
            workers.Add(2, pavel);
            
            SortedList sort = new SortedList();
            foreach (int l in keys)
            {
              Worker wr = workers[l] as Worker;
              sort.Add(l, wr);
            }
            Console.WriteLine("-----------------------Элементы SortedList----------------------------------");
            ICollection keys2 = sort.Keys;
            foreach (int k in keys2)
            {

                
                    Worker wr = workers[k] as Worker;
                    Console.WriteLine(k + ": " + wr.Name + "-" + wr.Profession);
                 

            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("------------------Поиск по ключу----------------------------------------");
            key2 = Convert.ToInt32(Console.ReadLine());
            foreach (int k in keys2)
            {

                if (key2 == k)
                {
                    Worker wr = workers[k] as Worker;
                    Console.WriteLine(k + ": " + wr.Name + "-" + wr.Profession);
                    flag2 = true;
                }

            }
            if (!flag2)
            {
                Console.WriteLine("Key not found");
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Введите количество удаляемых элементов---------------------------");
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                foreach (int k in keys2)
                {
                    sort.Remove(k);
                    break;
                }
                n--;
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("-------------------------------Оставшиеся элементы----------------------------------");
            foreach (int k in keys2)
            {


                Worker wr = workers[k] as Worker;
                Console.WriteLine(k + ": " + wr.Name + "-" + wr.Profession);


            }
            Console.WriteLine("--------------------------------------------------------------------");
            ObservableCollection<Worker> _workers = new ObservableCollection<Worker>
            {
               new Worker("Oleg","Admin"),
               new Worker("Pasha","Turner"),
               new Worker("Sasha","Driver"),

            };
            Console.WriteLine("-----------------------Наблюдаемоя коллекция------------------------");
            _workers.CollectionChanged += Users_CollectionChanged;
            _workers.Add(new Worker("Misha", "Mechanic"));
            _workers.RemoveAt(1);
            _workers[0] = new Worker("Tanya", "Finansist");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ReadKey();

        }
        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: 
                    Worker newWorker = e.NewItems[0] as Worker;
                    Console.WriteLine($"Добавлен новый объект: {newWorker.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: 
                    Worker ourWorker = e.OldItems[0] as Worker;
                    Console.WriteLine($"Удален объект: {ourWorker.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: 
                    Worker replacedUser = e.OldItems[0] as Worker;
                    Worker replacingUser = e.NewItems[0] as Worker;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }
       
        
    }
}
