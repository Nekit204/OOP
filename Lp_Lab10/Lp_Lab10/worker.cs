using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lp_Lab10
{
    class Worker:IEnumerable<Worker>
    {
        List<Worker> list = new List<Worker>();
        public string Name { get; set; }
        public string Profession { get; set; }
        public Worker(string name, string profession)
        {
            Name = name;
            Profession = profession;
        }
        public void Work()
        {
            Console.WriteLine($"Работник {Name} начал выполнять работу. ");
        }
        public void Rests()
        {
            Console.WriteLine($"Работник {Name} решил отдохнуть. ");
        }
        public IEnumerator<Worker> GetEnumerator()
        {
            foreach ( Worker wr in list)
                yield return wr;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
}
