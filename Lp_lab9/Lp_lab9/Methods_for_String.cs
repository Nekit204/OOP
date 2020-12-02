using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lp_lab9
{
   public static class Methods_for_String
    {
        public static string RemoveS(string str)       
        {
            str = str.Replace(".", string.Empty);
            str = str.Replace(",", string.Empty);
            str = str.Replace("!", string.Empty);
            str = str.Replace("?", string.Empty);
            str = str.Replace(":", string.Empty);
            str = str.Replace(";", string.Empty);
            str = str.Replace("-", string.Empty);
            return str;
        }


        public static string AddToString(string str)    
        {
            return str += "newstring";
        }


        public static string RemoveSpase(string str)   
        {
            return str.Replace(" ", string.Empty);
        }


        public static string Upper(string str)         
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(str[i], Char.ToUpper(str[i]));
            }
            return str;
        }


        public static string Lower(string str)         
        {
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace(str[i], Char.ToLower(str[i]));
            }
            return str;
        }
    }
}
