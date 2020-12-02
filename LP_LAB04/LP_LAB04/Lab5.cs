using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB04
{
    class Flower 
    {
        public string Name { get; set; }
        public  string Color { get; set; }
        public int Col { get; set; }
        public Flower(string name, string color, int col)
        {
            Color = color;
            Name = name;
            Col = col;
        }


        public override string ToString() => "Flower";
        public void ToWater()
        {
            Console.WriteLine("Вы поставили цветок в воду.");
        }

    }
}
