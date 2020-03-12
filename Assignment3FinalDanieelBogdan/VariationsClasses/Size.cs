using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    public enum SizeName
    {
        XS, S, M, L, XL, XXL, XXXL
    }
    public class Size
    {
        public SizeName Name { get; set; }
        public int Cost { get; set; }

        public Size(Random random)
        {
            Name = (SizeName)random.Next(Enum.GetNames(typeof(SizeName)).Length);
            Cost = Name.ToString().Length;
        }
    }
}
