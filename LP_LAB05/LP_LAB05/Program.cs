using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LP_LAB05
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bush bush = new Bush("Зеленый");
            //Rose rose = new Rose("Голландская роза", "белая");
            //Gladiolus gladiolus = new Gladiolus("Гладиолус полевой", "розовый");
            //Cactus cactus = new Cactus("зеленый", 0.2);
            //Bouquet bouquet = new Bouquet(rose.Name, rose.Color, 87);
            //Tree tree = new Tree("Зеленый", 76);
            //Paper paper = new Paper("Белый",tree.Made(tree.Col));
            //Console.WriteLine("Цветок:" + bouquet.Name + "-цвет:" + bouquet.Color+".Количество:"+bouquet.Col);
            //Console.WriteLine("Стоимость букета:" + bouquet.HowMuch(bouquet.Col));
            //Console.WriteLine(bush.Color + bush.ToString());
            //bush.Cut();
            //bush.Water();
            //Console.WriteLine("Цветок:" + rose.Name + "-цвет:" + rose.Color);
            //Console.WriteLine("Цветок:" + gladiolus.Name + "-цвет:" + gladiolus.Color);
            //rose.Water();
            //rose.Plant_Plant();
            //tree.Take_Plant();
            //gladiolus.Cut_Stem();
            //cactus.CanYouTakeCactusAtHome(cactus.Length);
            //Console.WriteLine("Цвет бумаги:" + paper.Color);
            //Console.WriteLine("Количество бумаги:" + paper.Col + "кг");
            //Plant[] arrPl = { bush, rose, gladiolus, tree, cactus};
            //Printer printer = new Printer();
            //foreach (var i in arrPl)
            //{
            //    printer.iAmPrinting(i);
            //}
            Log log = new Log();
            Bouque bouq = new Bouque();
            int SumofBouquet = 0;
            Flower[] arrflowers = { new Rose("Rose", "red",15), new Gladiolus("Gladiolus", "white",14), new Chamomile ("Chamomile","white",12) }; //15*100=1500,14*75=1050,12*50=600;sum=3150
            foreach (var i in arrflowers)
            {
                bouq.Add(i);

            }
            
            bouq.Show();

            // bouq.Remove(1);
             BouqueController.ReturnFlower(bouq, "white");
            BouqueController.ReturnFlower(bouq, "red");
            // BouqueController.ReturnFlower(bouq, "black");
            Console.WriteLine("Сортировка:");
            BouqueController.Sorted(bouq);
            SumofBouquet = BouqueController.FindSum(bouq);
            Console.WriteLine($"Стоимоть букета: {SumofBouquet}");
            BouqueController.WriteInfo(bouq);
            BouqueController.ReadInfo(bouq);
            Console.WriteLine("-----------------------------------------------------------------");
            try
            {
               Flower flowerException = new Flower(null,"red",24); 
            }
            catch (Exception exception)
            {
                log.WriteInFileLogger(exception);
                log.WriteInConsoleLogger(exception);
                //Console.WriteLine(exception.GetMessage);
                //Console.WriteLine(exception.StackTrace);
                //Console.WriteLine("Класс который вызвал ошибку: " + exception.Source);
                //Console.WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
                
            }
            Console.WriteLine("-----------------------------------------------------------------");
            try
            {
                Flower flowerException = new Flower("Rose", "red", -24);
            }
            catch (NullException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Класс который вызвал ошибку: " + exception.Source);
                Console.WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            try
            {
                Flower flowerException = new Flower("Rose", "grey", -24);
            }
            catch (Exception exception)
            {
                log.WriteInFileLogger(exception);
                log.WriteInConsoleLogger(exception);
                //Console.WriteLine(exception.GetMessage);
                //Console.WriteLine(exception.StackTrace);
                //Console.WriteLine("Класс который вызвал ошибку: " + exception.Source);
                //Console.WriteLine("Тип поля которое вызвало ошибку: " + exception.WhatData);
            }
            Console.WriteLine("-----------------------------------------------------------------");
            try
            {
                int[] arr1 = { 1, 2, 3 };
                int i = -4;
                if (i > arr1.Length || i < 0)
                {
                    throw new OutofRangeException(i, arr1.Length);
                }
                else
                {
                    Console.WriteLine(arr1[i].ToString());
                }
            }
            catch (OutofRangeException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
                Console.WriteLine("Вышло за пределы типа на значение: " + exception.OutValue.ToString());
                Console.WriteLine("Вышло за пределы массива на значение: " + exception.OutRange.ToString());
            }
            Console.WriteLine("------------------------------------------------");
            try
            {
                int x = 10;
                int y = 0;
                int result = (y == 0) ? throw new ArithmeticException() : x / y;
            }
            catch (ArithmeticException exception)
            {
                Console.WriteLine(exception.GetMessage);
                Console.WriteLine(exception.StackTrace);
            }
            finally
            {
                Console.WriteLine("Финал");
            }
            Console.WriteLine("------------------------------------------------");
            int[] aa = null;
            Debug.Assert(aa == null, "Values array cannot be null");
            Console.ReadKey(true);
        }
            
        
    }
}
