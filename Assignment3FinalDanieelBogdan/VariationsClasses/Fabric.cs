using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    public enum FabricName
    {
        CASHMERE,
        COTTON,
        LINEN,
        POLYESTER,
        RAYON,
        SILK,
        WOOL
    }
    public class Fabric
    {
        public FabricName Name { get; set; }
        public int Cost { get; set; }

        public Fabric(Random random)
        {
            Name = (FabricName)random.Next(Enum.GetNames(typeof(FabricName)).Length);
            Cost = Name.ToString().Length;
        }
    }
}
