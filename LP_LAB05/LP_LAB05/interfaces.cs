using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_LAB05
{
    public interface IMyPlant
     {
        void Take_Plant();
        void Plant_Plant();
     }
    public interface IMyFlower:IMyPlant
    {
        void Cut_Stem();

    }
    
}
