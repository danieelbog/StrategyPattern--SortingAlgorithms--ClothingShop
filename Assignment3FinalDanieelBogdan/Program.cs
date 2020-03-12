using Assignment3FinalDanieelBogdan.SortingClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3FinalDanieelBogdan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Darkness");
            Console.WriteLine("Please give a name to your Factory");
            var factory = new Factory();
            factory.FactoryName = Console.ReadLine();
            Console.WriteLine("Please give a name to your Shop");
            var shop = new Shop();
            shop.ShopName = Console.ReadLine();

            var random = new Random();
            int sortFlow = 0;
            int sortParameter = 0;
            int productNumber = 0;

            Console.WriteLine("Please choose what you want to create: ");
            Console.WriteLine("1) Tshirt");
            Console.WriteLine("2) Trousers");
            Console.WriteLine("3) Boots");

            var userChoice = Console.ReadLine();
            var trouserName = "Trousers";
            var bootsName = "Boots";
            var tshirtName = "Tshirt";            

            switch (userChoice)
            {
                // CASE REFERS TO PRODUCT - TSHIRT
                case "1":

                    // CREATING LIST TO ADD T-SHIRTS TO SELL
                    var listOfShirts = new List<Product>();
                    Console.WriteLine("How many Tshirts you want to make");
                    Console.WriteLine("1) 40");
                    Console.WriteLine("2) 50");
                    Console.WriteLine("3) 60");
                    productNumber = int.Parse(Console.ReadLine());

                    // ASKING HOW MANY TSHIRTS TO MAKE

                    switch (productNumber)
                    {
                        case 1:
                            for (int i = 0; i < 40; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Tshirt(color, size, fabric));
                                var shirtsCreated = factory.CreateObjectToSell(tshirtName);
                                listOfShirts.Add(shirtsCreated);
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 50; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Tshirt(color, size, fabric));
                                var shirtsCreated = factory.CreateObjectToSell(tshirtName);
                                listOfShirts.Add(shirtsCreated);
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 60; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Tshirt(color, size, fabric));
                                var shirtsCreated = factory.CreateObjectToSell(tshirtName);
                                listOfShirts.Add(shirtsCreated);
                            }
                            break;
                    }

                    // ASK THE USER TO PICK THE ID OF THE TSHIRT HE WANTS TO BUY
                    Console.WriteLine("Please pick the Shirt you want to buy");

                    // ASK THE USER TO PICK THE WAY HE WANTS TO SORT HIS LIST OF ITEMS
                    Console.WriteLine("Please pick the sort flow:");
                    Console.WriteLine("1) Ascending");
                    Console.WriteLine("2) Descending");
                    sortFlow = int.Parse(Console.ReadLine());

                    // ASK THE USER WHAT KIND OF SORT HE WANTS - VIA (COLOR-SIZE-FABRIC)
                    Console.WriteLine("Please pick the sort Parameter:");
                    Console.WriteLine("1) Color");
                    Console.WriteLine("2) Size");
                    Console.WriteLine("3) Fabric");
                    Console.WriteLine("4) All");
                    sortParameter = int.Parse(Console.ReadLine());                 

                    // BASED ON USER INPUT WE CHOOSE THE SORTING STRATEGY AND SORT ITEMS
                    if (listOfShirts.Count == 40)
                    {
                        shop.SetSortingStrategy(new BubleSort());
                        shop.PrintAll(listOfShirts, sortFlow, sortParameter);
                    }
                    else if (listOfShirts.Count == 50)
                    {
                        shop.SetSortingStrategy(new QuickSort());
                        shop.PrintAll(listOfShirts, sortFlow, sortParameter);
                    }
                    else
                    {
                        shop.SetSortingStrategy(new BucketSort());
                        shop.PrintAll(listOfShirts, sortFlow, sortParameter);
                    }
                    
                    // WE TAKE THE USER INPUT FOR WHAT SHIRT HE WANTS TO BUY
                    var shirtChoice = int.Parse(Console.ReadLine());
                    var tshirt = listOfShirts[shirtChoice - 1];

                    // PRINT GENERAL INFORMATION ABOUT WHAT USER HAS CHOOSED TO BUY AND WHAT IS HE PAYING FOR
                    Console.WriteLine("The total cost was a combination of:");
                    Console.WriteLine("Color: " + tshirt.Color.Cost + " Euros");
                    Console.WriteLine("Size: " + tshirt.Size.Cost + " Euros");
                    Console.WriteLine("Fabric: " + tshirt.Fabric.Cost + " Euros");
                    Console.WriteLine("Plus 1 euro of flat tax");
                    Console.WriteLine("For card and deposit you must pay commision 5 and 3 respectively");

                    // BASED ON THE BELOW CHEKCS THE SYSTEM WILL DECIDE THE WAY USER WILL PAY HIS PRODUCT
                    if (tshirt.Size.Cost == 2)
                    {
                        shop.SetPayStrategy(new Card());
                        Console.WriteLine("You are paying with Card");
                        shop.SellTShirt(tshirt);
                    }
                    else if (tshirt.Size.Cost == 3)
                    {
                        shop.SetPayStrategy(new Deposit());
                        Console.WriteLine("You are paying with Deposit");
                        shop.SellTShirt(tshirt);
                    }
                    else
                    {
                        shop.SetPayStrategy(new Cash());
                        Console.WriteLine("You are paying with Cash");
                        shop.SellTShirt(tshirt);
                    }

                    break;

                // CASE REFERS TO PRODUCT - TROUSERS
                case "2":

                    // CREATING LIST TO ADD T-SHIRTS TO SELL
                    var listOfTrousers = new List<Product>();
                    Console.WriteLine("How many Trousers you want to make");
                    Console.WriteLine("1) 40");
                    Console.WriteLine("2) 50");
                    Console.WriteLine("3) 60");
                    productNumber = int.Parse(Console.ReadLine());

                    switch (productNumber)
                    {
                        case 1:
                            for (int i = 0; i < 40; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Trouser(color, size, fabric));
                                var trouserCreated = factory.CreateObjectToSell(trouserName);
                                listOfTrousers.Add(trouserCreated);
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 50; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Trouser(color, size, fabric));
                                var trouserCreated = factory.CreateObjectToSell(trouserName);
                                listOfTrousers.Add(trouserCreated);
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 60; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Trouser(color, size, fabric));
                                var trouserCreated = factory.CreateObjectToSell(trouserName);
                                listOfTrousers.Add(trouserCreated);
                            }
                            break;
                    }

                    // ASK THE USER TO PICK THE NUMBER OF THE TROUSERS HE WANTS TO BUY
                    Console.WriteLine("Please pick the Trousers you want to buy");

                    // ASK THE USER TO PICK THE WAY HE WANTS TO SORT HIS LIST OF ITEMS
                    Console.WriteLine("Please pick the trousers you want to buy");
                    Console.WriteLine("Please pick the sort flow:");
                    Console.WriteLine("1) Ascending");
                    Console.WriteLine("2) Descending");
                    sortFlow = int.Parse(Console.ReadLine());

                    // ASK THE USER WHAT KIND OF SORT HE WANTS - VIA (COLOR-SIZE-FABRIC)
                    Console.WriteLine("Please pick the sort Parameter:");
                    Console.WriteLine("1) Color");
                    Console.WriteLine("2) Size");
                    Console.WriteLine("3) Fabric");
                    Console.WriteLine("4) All");
                    sortParameter = int.Parse(Console.ReadLine());

                    // BASED ON USER INPUT WE CHOOSE THE SORTING STRATEGY AND SORT ITEMS
                    if (listOfTrousers.Count == 40)
                    {
                        shop.SetSortingStrategy(new BubleSort());
                        shop.PrintAll(listOfTrousers, sortFlow, sortParameter);
                    }
                    else if (listOfTrousers.Count == 50)
                    {
                        shop.SetSortingStrategy(new QuickSort());
                        shop.PrintAll(listOfTrousers, sortFlow, sortParameter);
                    }
                    else
                    {
                        shop.SetSortingStrategy(new BucketSort());
                        shop.PrintAll(listOfTrousers, sortFlow, sortParameter);
                    }

                    // WE TAKE THE USER INPUT FOR WHAT TROUSER HE WANTS TO BUY
                    var trouserChoice = int.Parse(Console.ReadLine());
                    var trouser = listOfTrousers[trouserChoice - 1];

                    // PRINT GENERAL INFORMATION ABOUT WHAT USER HAS CHOOSED TO BUY AND WHAT IS HE PAYING FOR
                    Console.WriteLine("The total cost was a combination of:");
                    Console.WriteLine("Color :" + trouser.Color.Cost + " Euros");
                    Console.WriteLine("Size: " + trouser.Size.Cost + " Euros");
                    Console.WriteLine("Fabric: " + trouser.Fabric.Cost + " Euros");
                    Console.WriteLine("Plus 1 euro of flat tax");
                    Console.WriteLine("For card and deposit you must pay commision 5 and 3 respectively");

                    // BASED ON THE BELOW CHEKCS THE SYSTEM WILL DECIDE THE WAY USER WILL PAY HIS PRODUCT
                    if (trouser.Size.Cost == 2)
                    {
                        shop.SetPayStrategy(new Card());
                        Console.WriteLine("You are paying with Card");
                        shop.SellTShirt(trouser);
                    }
                    else if (trouser.Size.Cost == 3)
                    {
                        shop.SetPayStrategy(new Deposit());
                        Console.WriteLine("You are paying with Deposit");
                        shop.SellTShirt(trouser);
                    }
                    else
                    {
                        shop.SetPayStrategy(new Cash());
                        Console.WriteLine("You are paying with Cash");
                        shop.SellTShirt(trouser);

                    }

                    break;

                // CASE REFERS TO PRODUCT - BOOTS
                case "3":

                    // CREATING LIST TO ADD T-SHIRTS TO SELL
                    var listOfBoots = new List<Product>();
                    Console.WriteLine("How many Trousers you want to make");
                    Console.WriteLine("1) 40");
                    Console.WriteLine("2) 50");
                    Console.WriteLine("3) 60");
                    productNumber = int.Parse(Console.ReadLine());

                    switch (productNumber)
                    {
                        case 1:
                            for (int i = 0; i < 40; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Boot(color, size, fabric));
                                var bootCreated = factory.CreateObjectToSell(bootsName);
                                listOfBoots.Add(bootCreated);
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 50; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Boot(color, size, fabric));
                                var bootCreated = factory.CreateObjectToSell(bootsName);
                                listOfBoots.Add(bootCreated);
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 60; i++)
                            {
                                // GENERATE RANDOM COLOR-SIZE-FABRIC
                                var color = new Color(random);
                                var size = new Size(random);
                                var fabric = new Fabric(random);

                                // WE SET THE CHARACHTERISTICS FOR THE BOOT (BASICALLY WE USE STRATEGY PATTERN TO CREATE AN OBJECT ON RUN TIME BASED ON USER INPUT).
                                factory.SetCharachteristic(new Boot(color, size, fabric));
                                var bootCreated = factory.CreateObjectToSell(bootsName);
                                listOfBoots.Add(bootCreated);
                            }
                            break;
                    }                  

                    // ASK THE USER TO PICK THE NUMBER OF THE BOOTS HE WANTS TO BUY
                    Console.WriteLine("Please pick the Trousers you want to buy");

                    // ASK THE USER TO PICK THE WAY HE WANTS TO SORT HIS LIST OF ITEMS
                    Console.WriteLine("Please pick the Shirt you want to buy");
                    Console.WriteLine("Please pick the sort flow:");
                    Console.WriteLine("1) Ascending");
                    Console.WriteLine("2) Descending");
                    sortFlow = int.Parse(Console.ReadLine());

                    // ASK THE USER WHAT KIND OF SORT HE WANTS - VIA (COLOR-SIZE-FABRIC)
                    Console.WriteLine("Please pick the sort Parameter:");
                    Console.WriteLine("1) Color");
                    Console.WriteLine("2) Size");
                    Console.WriteLine("3) Fabric");
                    Console.WriteLine("4) All");
                    sortParameter = int.Parse(Console.ReadLine());

                    // BASED ON USER INPUT WE CHOOSE THE SORTING STRATEGY AND SORT ITEMS
                    if (listOfBoots.Count == 40)
                    {
                        shop.SetSortingStrategy(new BubleSort());
                        shop.PrintAll(listOfBoots, sortFlow, sortParameter);
                    }
                    else if (listOfBoots.Count == 50)
                    {
                        shop.SetSortingStrategy(new QuickSort());
                        shop.PrintAll(listOfBoots, sortFlow, sortParameter);
                    }
                    else
                    {
                        shop.SetSortingStrategy(new BucketSort());
                        shop.PrintAll(listOfBoots, sortFlow, sortParameter);
                    }

                    // WE TAKE THE USER INPUT FOR WHAT BOOTS HE WANTS TO BUY
                    var bootChoice = int.Parse(Console.ReadLine());
                    var boot = listOfBoots[bootChoice - 1];

                    // PRINT GENERAL INFORMATION ABOUT WHAT USER HAS CHOOSED TO BUY AND WHAT IS HE PAYING FOR
                    Console.WriteLine("The total cost was a combination of:");
                    Console.WriteLine("Color: " + boot.Color.Cost + " Euros");
                    Console.WriteLine("Size: " + boot.Size.Cost + " Euros");
                    Console.WriteLine("Fabric: " + boot.Fabric.Cost + " Euros");
                    Console.WriteLine("Plus 1 euro of flat tax");
                    Console.WriteLine("For card and deposit you must pay commision 5 and 3 respectively");

                    // BASED ON THE BELOW CHEKCS THE SYSTEM WILL DECIDE THE WAY USER WILL PAY HIS PRODUCT
                    if (boot.Size.Cost == 2)
                    {
                        shop.SetPayStrategy(new Card());
                        Console.WriteLine("You are paying with Card");
                        shop.SellTShirt(boot);
                    }
                    else if (boot.Size.Cost == 3)
                    {
                        shop.SetPayStrategy(new Deposit());
                        Console.WriteLine("You are paying with Deposit");
                        shop.SellTShirt(boot);
                    }
                    else
                    {
                        shop.SetPayStrategy(new Cash());
                        Console.WriteLine("You are paying with Cash");
                        shop.SellTShirt(boot);
                    }

                    break;

                    //BAD DEFAULS SCENARIO FOR SOMETHING BAD
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
        }

    }
}

