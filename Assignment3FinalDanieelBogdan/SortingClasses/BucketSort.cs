using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan.SortingClasses
{
    class BucketSort : IsortStrategy
    {
        public List<Product> SortAcsending(List<Product> products, int sortParameter)
        {
            Console.WriteLine("Bucket Sort is Running in Ascending Mode");
            var sortedList = SortShirts(products, sortParameter);
            var listOfProducts = InsertionSortBucket(sortedList, sortParameter);

            return listOfProducts;
        }

        public List<Product> SortDescending(List<Product> products, int sortParameter)
        {
            Console.WriteLine("Bucket Sort is Running in Descending Mode");
            var sortedList = SortShirts(products, sortParameter);
            var listOfProducts = InsertionSortBucket(sortedList, sortParameter);

            listOfProducts.Reverse();
            return listOfProducts;
        }

        public static List<Product> SortShirts(List<Product> products, int sortParameter)
        {
            List<Product> sortedList = new List<Product>();

            int numOfBuckets = 4;

            //create buckets
            List<Product>[] buckets = new List<Product>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Product>();
            }

            //Iterate through the passed array and add each integer to the appropriate bucket
            for (int i = 0; i < products.Count; i++)
            {
                int bucket = (int)products[i].Color.Name;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(products[i]);
            }

            // Sort each bucket, add it to the result
            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Product> temp = InsertionSortBucket(buckets[i], sortParameter);
                sortedList.AddRange(temp);
            }

            return sortedList;
        }

        public static List<Product> InsertionSortBucket(List<Product> products, int sortParameter)
        {
            Product temp;

            switch (sortParameter)
            {
                // CASE FOR COLOR
                case 1:
                    for (int i = 1; i < products.Count; i++)
                    {
                        // Store current value in a variable
                        int currentValue = (int)products[i].Color.Name;
                        int pointer = i - 1;

                        while (pointer >= 0)
                        {
                            if (currentValue < (int)products[pointer].Color.Name)
                            {
                                temp = products[pointer + 1];
                                products[pointer + 1] = products[pointer];
                                products[pointer] = temp;
                                pointer--;
                            }
                            else break;
                        }
                    }
                    return products;
                    // CASE FOR SIZE
                case 2:
                    for (int i = 1; i < products.Count; i++)
                    {
                        // Store current value in a variable
                        int currentValue = (int)products[i].Size.Name;
                        int pointer = i - 1;

                        while (pointer >= 0)
                        {
                            if (currentValue < (int)products[pointer].Size.Name)
                            {
                                temp = products[pointer + 1];
                                products[pointer + 1] = products[pointer];
                                products[pointer] = temp;
                                pointer--;
                            }
                            else break;
                        }
                    }
                    return products;
                    // CASE FOR FABRIC
                case 3:
                    for (int i = 1; i < products.Count; i++)
                    {
                        // Store current value in a variable
                        int currentValue = (int)products[i].Fabric.Name;
                        int pointer = i - 1;

                        while (pointer >= 0)
                        {
                            if (currentValue < (int)products[pointer].Fabric.Name)
                            {
                                temp = products[pointer + 1];
                                products[pointer + 1] = products[pointer];
                                products[pointer] = temp;
                                pointer--;
                            }
                            else break;
                        }
                    }
                    return products;
                    // CASE FOR ALL
                case 4:
                    for (int i = 1; i < products.Count; i++)
                    {
                        // Store current value in a variable
                        int currentValue1 = (int)products[i].Size.Name;
                        int pointer1 = i - 1;

                        while (pointer1 >= 0)
                        {
                            if (currentValue1 < (int)products[pointer1].Size.Name)
                            {
                                temp = products[pointer1 + 1];
                                products[pointer1 + 1] = products[pointer1];
                                products[pointer1] = temp;
                                pointer1--;
                            }
                            else break;

                        }

                        // Store current value in a variable
                        int currentValue2 = (int)products[i].Color.Name;
                        int pointer2 = i - 1;

                        while (pointer2 >= 0)
                        {
                            if (currentValue2 < (int)products[pointer2].Color.Name)
                            {
                                temp = products[pointer2 + 1];
                                products[pointer2 + 1] = products[pointer2];
                                products[pointer2] = temp;
                                pointer2--;
                            }
                            else break;

                        }

                        // Store current value in a variable
                        int currentValue3 = (int)products[i].Color.Name;
                        int pointer3 = i - 1;

                        while (pointer3 >= 0)
                        {
                            if (currentValue3 < (int)products[pointer3].Color.Name)
                            {
                                temp = products[pointer3 + 1];
                                products[pointer3 + 1] = products[pointer3];
                                products[pointer3] = temp;
                                pointer3--;
                            }
                            else break;

                        }
                    }
                    return products;
                default:
                    Console.WriteLine("WARNING, THERE WAS A PROBLEM WITH YOUR INSERTION SORT BUCKET");
                    break;
            }

            return null;
            
        }
    }
}
