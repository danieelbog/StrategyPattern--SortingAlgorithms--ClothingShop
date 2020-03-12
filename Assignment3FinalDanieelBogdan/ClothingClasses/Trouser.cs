using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    class Trouser : Product, ICharachteristics
    {
        public Trouser(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Size = size;
            Fabric = fabric;
        }

        public Product GetClothingType(string clothingType)
        {
            var trouser = new Trouser(Color, Size, Fabric);
            return trouser;
        }

    }
}
