using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace LP_Lab12
{
    class Reflector
    {
        static Random rnd = new Random();
        public static void WriteClassInfo(string className)              
        {
            Type type = Type.GetType(className);
            using (StreamWriter file = new StreamWriter("C:\\Users\\User\\Desktop\\учеба\\2 курс\\ООТП\\Лабораторные\\LP_Lab12.txt",false))
            {
                file.WriteLine("---------------------------ClassInfo----------");
                foreach (var item in type.GetMembers())
                {
                    file.WriteLine(item.Name);
                }
                file.WriteLine("-----------------------------------------------");
            }
        }
        public static void PublicMethods(string className)
        {
            Type type = Type.GetType(className);
            using (StreamWriter file = new StreamWriter("C:\\Users\\User\\Desktop\\учеба\\2 курс\\ООТП\\Лабораторные\\LP_Lab12.txt", true))
            {
                file.WriteLine("---------------------------Methods----------");
                foreach (var item in type.GetMethods())
                {
                    if (item.IsPublic)
                    {
                        file.WriteLine(item.Name);
                    }
                }
                file.WriteLine("-----------------------------------------------");
            }

        }
        public static void PropertiesAndFields(string className)                        
        {
            Type type = Type.GetType(className);
            using (StreamWriter file = new StreamWriter("C:\\Users\\User\\Desktop\\учеба\\2 курс\\ООТП\\Лабораторные\\LP_Lab12.txt",true))
            {
                file.WriteLine("------------------------Fields--------------------------------------------");
                foreach (var item in type.GetFields())
                {
                    file.WriteLine(item);
                }
                file.WriteLine("-----------------------------------------------");
                file.WriteLine("\n-------------------------Properties---------------------------------------");
                foreach (var item in type.GetProperties())
                {
                    file.WriteLine(item);
                }
                file.WriteLine("-----------------------------------------------");
            }
        }


        public static void InterfacesInClass(string className)                            
        {
            Type type = Type.GetType(className);
            using (StreamWriter file = new StreamWriter("C:\\Users\\User\\Desktop\\учеба\\2 курс\\ООТП\\Лабораторные\\LP_Lab12.txt", true))
            {
                file.WriteLine("------------------------Interfaces--------------------------------------------");
                foreach (var item in type.GetInterfaces())
                {
                    file.WriteLine(item);
                }
                file.WriteLine("-----------------------------------------------");
            }
        }


        public static void MethodsByParametres(string className, string param)  
        {
            Type type = Type.GetType(className);
            using (StreamWriter file = new StreamWriter("C:\\Users\\User\\Desktop\\учеба\\2 курс\\ООТП\\Лабораторные\\LP_Lab12.txt", true))
            {
                file.WriteLine("------------------------MethodsByParametres--------------------------------------------");
                foreach (var item in type.GetMethods())
                {
                    foreach (var par in item.GetParameters())
                    {
                        if (par.ToString() == param)
                        {
                            file.WriteLine(item.Name);
                        }
                    }
                }
                file.WriteLine("-----------------------------------------------");
            }
        }
        public static object Invoke_random(string className, string methodName)
        {
            int value1 = rnd.Next(0,30);
            Type type = Type.GetType(className);
            var constructor = type.GetConstructor(Type.EmptyTypes);
            object par = constructor.Invoke(new object[] { });
            MethodInfo method = type.GetMethod(methodName);
            object result = method.Invoke(par, new object[] { value1 });
            return result;
        }
        public static object Invoke_from_file(string className, string methodName)
        {
            int value2 = 0;
            using (StreamReader file = new StreamReader("C:\\Users\\User\\Desktop\\учеба\\2 курс\\ООТП\\Лабораторные\\Parametrs.txt"))
            {
                 value2=Convert.ToInt32(file.ReadLine());
            }
            Type type = Type.GetType(className);
            var constructor = type.GetConstructor(Type.EmptyTypes);
            object par = constructor.Invoke(new object[] { });
            MethodInfo method = type.GetMethod(methodName);
            object result = method.Invoke(par, new object[] { value2 });
            return result;
        }
        public static object Create(Type type, Type[] parametersType)
        {
           
            var constructor = type.GetConstructor(parametersType);
            object classObject = constructor?.Invoke(new object[] { });

            return classObject;
        }

    }
}
