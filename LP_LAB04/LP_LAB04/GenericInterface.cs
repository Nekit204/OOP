using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB04
{
    
        interface IGeneric<T>
        {
            void Add(T variables);
            void Delete(T variables);
            void Show();
        }
    
}
