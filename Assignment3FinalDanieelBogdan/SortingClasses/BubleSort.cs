using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan.SortingClasses
{
    public class BubleSort : IsortStrategy
    {
        public List<Product> SortAcsending(List<Product> products, int sortParameter)
        {
            Product temp;
            Console.WriteLine("Bubble Sort is Running in Ascending Mode");

            switch (sortParameter)
            {
                // CASE FOR COLOR
                case 1:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Color.Name > products[i + 1].Color.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                // CASE FOR SIZE
                case 2:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Size.Name > products[i + 1].Size.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                // CASE FOR FABRIC
                case 3:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Fabric.Name > products[i + 1].Fabric.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                // CASE FOR ALL
                case 4:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Fabric.Name > products[i + 1].Fabric.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }

                            if (products[i].Size.Name > products[i + 1].Size.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }

                            if (products[i].Color.Name > products[i + 1].Color.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("WARNING AN ERROR OCCURED AT BUBBLE ASCENDING SWITCH CASE");
                    break;
            }
            
            return products;
        }

        public List<Product> SortDescending(List<Product> products, int sortParameter)
        {
            Product temp;
            Console.WriteLine("Bubble Sort is Running in Descending Mode");

            switch (sortParameter)
            {
                // CASE FOR COLOR
                case 1:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Color.Name < products[i + 1].Color.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                // CASE FOR SIZE
                case 2:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Size.Name < products[i + 1].Size.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                // CASE FOR FABRIC
                case 3:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Fabric.Name < products[i + 1].Fabric.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                    // CASE FOR ALL
                case 4:
                    for (int j = 0; j <= products.Count - 2; j++)
                    {
                        for (int i = 0; i <= products.Count - 2; i++)
                        {
                            if (products[i].Color.Name < products[i + 1].Color.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }

                            if (products[i].Size.Name < products[i + 1].Size.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }

                            if (products[i].Fabric.Name < products[i + 1].Fabric.Name)
                            {
                                temp = products[i + 1];
                                products[i + 1] = products[i];
                                products[i] = temp;
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("WARNING AN ERROR OCCURED AT BUBBLE DESCENDING SWITCH CASE");
                    break;  
            }

            return products;
        }
    }
}
