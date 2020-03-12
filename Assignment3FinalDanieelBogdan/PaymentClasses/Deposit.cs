using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    class Deposit : IPayStrategy
    {
        public double Pay(Product charachteristics)
        {
            return charachteristics.Color.Cost + charachteristics.Fabric.Cost + charachteristics.Size.Cost + 3 + 1;
        }
    }
}
