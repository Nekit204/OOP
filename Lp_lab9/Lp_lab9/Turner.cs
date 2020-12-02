using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_lab9
{
    class Turner
    {
        int count = 15;
        int salary = 500;
        public void GetNewInfo() => Console.WriteLine("Токарь получил повышение до старшего мастера.Количество токарей:" + (--count));
        public void GetNewInfo(string mes, int sm) => Console.WriteLine($"Причина штрафа:{mes}.Сумма штрафа:{sm}." + "Новая сумма:" + (salary -= sm) + ".Be happy");
    }
}
