using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Reflector.WriteClassInfo("LP_Lab12.Customer");
            Reflector.PublicMethods("LP_Lab12.Customer");
            Reflector.PropertiesAndFields("LP_Lab12.Customer");
            Reflector.InterfacesInClass("LP_Lab12.Customer");
            Reflector.MethodsByParametres("LP_Lab12.Customer", "Int32 value");
            object result1 = Reflector.Invoke_random("LP_Lab12.MyClass", "Upplication");
            object result3 = Reflector.Invoke_random("LP_Lab12.MyClass", "Upplication");
            object result2 = Reflector.Invoke_from_file("LP_Lab12.MyClass", "Upplication");

            Console.WriteLine("Работа Invoke_random:"+result1);
            Console.WriteLine("Работа Invoke_random:"+result3);
            Console.WriteLine("Работа Invoke_from_file:" + result2);
            var a = Reflector.Create(typeof(List<int>), Type.EmptyTypes) as List<int>;
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            foreach (var e in a)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey(true);

        }
    }
}
