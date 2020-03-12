using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    interface ICharachteristics
    {
        Color Color { get; set; }
        Size Size { get; set; }
        Fabric Fabric { get; set; }
        Product GetClothingType(string clothingType);
        void Output();
    }
}
