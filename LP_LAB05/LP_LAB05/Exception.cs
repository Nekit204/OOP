using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB05
{
    class NullException:Exception
    {
        private string message, field;
        public NullException(object obj)
        {
            field = "-";
            Source = obj.GetType().ToString();
            message = "На конструктор было подано null значение";
        }
        public NullException(object obj, Type fieldType)
        {
            field = fieldType.ToString();
            Source = obj.GetType().ToString();
            message = "На конструктор было подано неверное значение";
        }
        
        public string GetMessage => message;
        public string WhatData => field;
    }
    class ColorException : Exception
    {

        private string message, field;
        public ColorException(object obj,Type fieldType)  
        {
            field = fieldType.ToString();
            Source = obj.GetType().ToString();
            message = "Отменяем серые цветы в мире таких не сущесвует нужны более яркие цвета";
        }
        public string GetMessage => message;
        public string WhatData => field;
    }
    class OutofRangeException : Exception
    {
        private string message;
        private int usedindex, range;
        private long outvalue;
        public OutofRangeException(int value, int arrlength)
        {
            usedindex = value;
            range = arrlength;
            outvalue = 0;
            message = "Выход за пределы размера массива";
        }
        public string GetMessage => message;
        public long OutValue => outvalue;
        public int OutRange
        {
            get
            {
                if (usedindex < 0)
                    return usedindex;
                return usedindex - range;
            }
        }
    }
    class ArithmeticException : Exception
    {
        private string message;
        public ArithmeticException()
        {
            message = "Арифметическая ошибка";
        }
        public string GetMessage => message;
    }
}

