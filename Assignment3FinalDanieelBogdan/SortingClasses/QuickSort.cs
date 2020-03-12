using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan.SortingClasses
{
    public class QuickSort : IsortStrategy
    {
        public List<Product> SortAcsending(List<Product> products, int sortParameter)
        {
            Console.WriteLine("Quick Sort is Running in Ascending Mode");

            var arr = products.ToArray();

            QuickSort.quickSort(arr, 0, arr.Length - 1, sortParameter);
            QuickSort.partition(arr, 0, arr.Length - 1, sortParameter);

            var newList = arr.ToList();
            return newList;
        }

        public List<Product> SortDescending(List<Product> products, int sortParameter)
        {
            Console.WriteLine("Quick Sort is Running in Descending Mode");

            var arr = products.ToArray();

            QuickSort.quickSort(arr, 0, arr.Length - 1, sortParameter);
            QuickSort.partition(arr, 0, arr.Length - 1, sortParameter);

            var newList = arr.ToList();
            newList.Reverse();
            return newList;
        }

        static void quickSort(Product[] arr, int low, int high, int sortParameter)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high, sortParameter);

                // Recursively sort elements before
                // partition and after partition
                quickSort(arr, low, pi - 1, sortParameter);
                quickSort(arr, pi + 1, high, sortParameter);
            }
        }

        static int partition(Product[] arr, int low, int high, int sortParameter)
        {
            Product pivot = arr[high];

            switch (sortParameter)
            {
                case 1:
                    // index of smaller element
                    int i1 = (low - 1);
                    for (int j = low; j < high; j++)
                    {
                        // If current element is smaller  
                        // than the pivot
                        if (arr[j].Color.Name < pivot.Color.Name)
                        {
                            i1++;

                            // swap arr[i] and arr[j]
                            Product temp = arr[i1];
                            arr[i1] = arr[j];
                            arr[j] = temp;
                        }
                    }

                    // swap arr[i+1] and arr[high] (or pivot)
                    Product temp1 = arr[i1 + 1];
                    arr[i1 + 1] = arr[high];
                    arr[high] = temp1;

                    return i1 + 1;
                case 2:
                    // index of smaller element
                    int i2 = (low - 1);
                    for (int j = low; j < high; j++)
                    {
                        // If current element is smaller  
                        // than the pivot
                        if (arr[j].Size.Name < pivot.Size.Name)
                        {
                            i2++;

                            // swap arr[i] and arr[j]
                            Product temp = arr[i2]
                            arr[i2] = arr[j];
                            arr[j] = temp;
                        }
                    }

                    // swap arr[i+1] and arr[high] (or pivot)
                    Product temp2 = arr[i2 + 1];
                    arr[i2 + 1] = arr[high];
                    arr[high] = temp2;

                    return i2 + 1;
                case 3:
                    // index of smaller element
                    int i3 = (low - 1);
                    for (int j = low; j < high; j++)
                    {
                        // If current element is smaller  
                        // than the pivot
                        if (arr[j].Fabric.Name < pivot.Fabric.Name)
                        {
                            i3++;

                            // swap arr[i] and arr[j]
                            Product temp = arr[i3];
                            arr[i3] = arr[j];
                            arr[j] = temp;
                        }
                    }

                    // swap arr[i+1] and arr[high] (or pivot)
                    Product temp3 = arr[i3 + 1];
                    arr[i3 + 1] = arr[high];
                    arr[high] = temp3;

                    return i3 + 1;
                default:
                    Console.WriteLine("WARNING SOMETHING WAS WRONG WITH THE QUICK SORT SORTING ALGORITHM");
                    break;
            }

            return 404;          
        }

    }
}
