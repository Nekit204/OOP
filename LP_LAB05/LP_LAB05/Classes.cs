using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB05
{
    class Printer
    {
        public void iAmPrinting(Plant someobj)     
        {
            Console.WriteLine("Тип объекта = " + someobj.ToString());
        }
    }
    abstract class Plant
    {
        public string Color { get; set; }
        public Plant(string color)
        {
            Color = color;
            if (color == "grey") throw new ColorException(this,color.GetType());
        }
        public override string ToString() => "Plant";
       virtual public void Water()
        {
            Console.WriteLine("Вы полили растение.");
        }

    }
    sealed class Bush:Plant,IMyPlant
     {
        public void Plant_Plant() =>Console.WriteLine("Вы посадили куст");
        public void Take_Plant() => Console.WriteLine("Вы срубили куст");
        public Bush(string color) : base(color) { }
        public void Cut()
        {
            Console.WriteLine("Вы подстригли куст.");
        }
        

    }
     class Flower : Plant
    {
        public string Name { get; set; }
          public new string  Color { get; set; }
        public int Col { get; set; }
        public Flower(string name,string color,int col):base(color)
        {
            Color = color?? throw new NullException(this);
            Name = name ??throw new NullException(this) ;
            Col = col;
            if (col < 0) throw new NullException(this, col.GetType());
        }
       

        public override string ToString() => "Flower";
        override public void Water()
        {
            Console.WriteLine("Вы поставили цветок в воду.");
        }

    }
     class Rose : Flower, IMyFlower
    {
        
        public override string ToString() => "Rose";
        public void Plant_Plant() => Console.WriteLine("Вы посадили розу.");
        public void Take_Plant() => Console.WriteLine("Вы сорвали розу. ");
       public void Cut_Stem() => Console.WriteLine("Вы обрезали стебель.");
        public Rose(string name, string color,int col) : base(name, color,col) { }

    }
     class Gladiolus : Flower,IMyFlower
    {
        public override string ToString() => "Gladiolus";
        public void Plant_Plant() => Console.WriteLine("Вы посадили гладиолус");
        public void Take_Plant() => Console.WriteLine("Вы сорвали гладиолус. ");
         public void Cut_Stem() => Console.WriteLine("Вы обрезали стебель.");
         
        public Gladiolus(string name, string color,int col) : base(name, color,col) { }
    }
    class Chamomile : Flower 
    {
        public override string ToString() => "Chamomile";
        public Chamomile(string name, string color,int col) : base(name, color,col) { }
    }
    sealed class Cactus: Plant,IMyPlant
    {
        public void Plant_Plant() => Console.WriteLine("Вы посадили кактус");
        public void Take_Plant() => Console.WriteLine("Вы сорвали кактус");
        public double Length { get; set; }
        public Cactus(string color,double length) : base(color) 
        {
            Length = length;
        }

        public void CanYouTakeCactusAtHome(double length)//метры
        {
            if (length<1&&length>0)
            {
                Console.WriteLine("Можете забрать кактус с собой");
            }
             if(length>1)
            {
                Console.WriteLine("Кактус слишком большой.");
            }

        }
    }
    sealed partial class Bouquet : Rose
    {
        public new int Col { get; set; }
        public int oneFl = 100;
        public int sum = 0;
        public Bouquet(string name,string color,int col):base(name,color,col)
        {
            Col = col;
        }
        public int HowMuch(int col)
        {
            sum = col * oneFl;
            return sum;
        }
    }
    class Tree : Plant ,IMyPlant
    {
        public void Plant_Plant() => Console.WriteLine("Вы посадили дерево");
        public void Take_Plant() => Console.WriteLine("Вы срубили дерево");
        public int Col { get; set; }
        public int alot = 0;
        public Tree(string color,int col) : base(color)
        {
           
            Col = col;
        }
        public int Made(int col)//1 дерево=10 кг бумаги
        {
            
            return col*10;
        }
    }

    sealed class Paper : Tree
    {
        public Paper(string color, int col) : base(color, col) { }
      
    }
  
}
