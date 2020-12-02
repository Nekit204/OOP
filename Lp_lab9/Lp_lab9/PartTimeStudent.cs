using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_lab9
{
    public class PartTimeStudent
    {
        int count = 10;
        public void GetNewInfo() => Console.WriteLine("Студент получил квалификацию.Количество студентов:"+(--count));
    }
}
