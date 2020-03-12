using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    public enum ColorName
    {
        BLUE,
        GREEN,
        INDIGO,
        ORANGE,
        RED,
        VIOLET,
        YELLOW
    }
    public class Color
    {        
        public ColorName Name { get; set; }
        public int Cost { get; set; }

        public Color(Random random)
        {
            Name = (ColorName)random.Next(Enum.GetNames(typeof(ColorName)).Length);
            Cost = Name.ToString().Length;
        }
    }
}
