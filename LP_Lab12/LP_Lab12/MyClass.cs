using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Lab12
{
    class MyClass:ICloneable
    {
        int number;
        public int MyNumber { get => number; set => number = value; }
        public void Method()
        {
            Console.WriteLine("Method");
        }
        private int Value;

        public MyClass()
        {
            Value = 5;
        }

        public int Upplication(int number)
        {
            return number *Value;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
