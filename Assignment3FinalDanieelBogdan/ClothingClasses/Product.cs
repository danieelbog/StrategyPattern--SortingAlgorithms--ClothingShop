using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    public class Product
    {
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Fabric Fabric { get; set; }
        public void Output()
        {
            Console.WriteLine("{0,12}|{1,12}|{2,12}", Color.Name, Size.Name, Fabric.Name);
        }

    }
}
