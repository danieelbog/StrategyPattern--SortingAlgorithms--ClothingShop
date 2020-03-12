using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    class Tshirt : Product, ICharachteristics
    {
        public Tshirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public Product GetClothingType(string clothingType)
        {
            var tshirt = new Tshirt(Color, Size, Fabric);
            return tshirt;
        }
    }
}
