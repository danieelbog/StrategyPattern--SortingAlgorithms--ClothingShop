using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    public class Boot : Product, ICharachteristics
    {
        public Boot(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public Product GetClothingType(string clothingType)
        {
            var boot = new Boot(Color, Size, Fabric);
            return boot;
        }

    }
}
