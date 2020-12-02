using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_lab9
{
    public class Director
    {
        private event Fine fine;
        private event Increase increase;
        public void Give_a_fine(string mes,int sum) => fine.Invoke( mes, sum);
        public void Raise() => increase.Invoke();
        public Fine fn { get => fine; set => fine = value; }
        public Increase inc { get => increase; set => increase=value; }
    }
}
