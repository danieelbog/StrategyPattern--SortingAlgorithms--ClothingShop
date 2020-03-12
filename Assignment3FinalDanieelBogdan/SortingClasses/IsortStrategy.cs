using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    interface IsortStrategy
    {
        List<Product> SortAcsending(List<Product> products, int sortParameter);
        List<Product> SortDescending(List<Product> products, int sortParameter);
    }
}
