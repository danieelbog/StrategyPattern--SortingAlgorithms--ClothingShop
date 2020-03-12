using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    class Shop
    {
        public string ShopName { get; set; }
        public IPayStrategy _payStrategy { get; set; }
        public IsortStrategy _sortStrategy { get; set; }

        public void SetPayStrategy(IPayStrategy payStrategy)
        {
            _payStrategy = payStrategy;
        }
        public void SetSortingStrategy(IsortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void SellTShirt(Product charachteristics)
        {
            var sellObject = _payStrategy.Pay(charachteristics);
            Console.WriteLine($"The cost of the tshirt is: " + sellObject);
        }

        public void PrintAll(List<Product> products, int sortFlow, int sortParameter)
        {
            switch (sortFlow)
            {
                case 1:
                    var sortedAscendingList = _sortStrategy.SortAcsending(products, sortParameter);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0,12}|{1,12}|{2,12}", "Color", "Size", "Fabric");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var item in sortedAscendingList)
                    {
                        item.Output();
                    }
                    break;
                case 2:
                    var sortedAsortedDescendingList = _sortStrategy.SortDescending(products, sortParameter);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0,12}|{1,12}|{2,12}", "Color", "Size", "Fabric");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (var item in sortedAsortedDescendingList)
                    {
                        item.Output();
                    }
                    break;
            }
           
        }
    }
}
