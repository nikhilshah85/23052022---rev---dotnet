using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace collections_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array

            #region Array 1 
            //int[] myNumbers = new int[5];
            //myNumbers[0] = 10;
            //myNumbers[1] = 20;
            //myNumbers[2] = 30;
            //myNumbers[3] = 40;
            //myNumbers[4] = 50;
            ////myNumbers[5] = 60; // Index out of bond exception
            ////Console.WriteLine(myNumbers[3]);

            //for (int i = 0; i < myNumbers.Length; i++)
            //{
            //    Console.WriteLine(myNumbers[i]);
            //}

            #endregion

            #region Array 2
            //Console.WriteLine("How many values do you wish to store and process");
            //int total = Convert.ToInt32(Console.ReadLine());

            //int[] myNumbers = new int[total];

            //for (int i = 0; i < total; i++)
            //{
            //Console.WriteLine("Enter Number : " + (i + 1);
            //    myNumbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //int evens = 0;
            //int odds = 0;
            //int negatives = 0;

            //for (int i = 0; i < total; i++)
            //{
            //    sum = sum + myNumbers[i];

            //    if (myNumbers[i] % 2 == 0)
            //    {
            //        evens = evens + 1;
            //    }
            //    else
            //    {
            //        odds = odds + 1;
            //    }
            //    if (myNumbers[i] < 0)
            //    {
            //        negatives = negatives + 1;
            //    }
            //}

            //Console.WriteLine("Total of all your numbers " + sum);
            //Console.WriteLine("Total Even numbers " + evens);
            //Console.WriteLine("Total Odd numbers " + odds);
            //Console.WriteLine("Total Negative numbers " + negatives);
            #endregion

            #region Array 3
            //string[] friends = new string[5];
            //friends[0] = "Kate W";
            //friends[1] = "Leo";
            //friends[2] = "Micheal";
            //friends[3] = "Kane";
            //friends[4] = "Steve";

            //for (int i = 0; i < friends.Length; i++)
            //{
            //    Console.WriteLine(friends[i]);
            //}
            #endregion

            //Products[] products = new Products[5];
            //products[0] = new Products() { }

            #endregion

            #region ArrayList
            //ArrayList myNumbers = new ArrayList();
            //myNumbers.Add(10);
            //myNumbers.Add("Nik");
            //myNumbers.Add(true);
            //myNumbers.Add(20.30);
            //myNumbers.Add("Kate");
            //myNumbers.Add(".Net");
            //myNumbers.Add(150);
            //myNumbers.Add(500.8999);
            //myNumbers.Add(new Products() { pId = 101, pName = "Pepsi", pCategory = "Cold-Drink", pIsInStock = true, pPrice = 3 });
            //myNumbers.Add(10);
            //myNumbers.Add(20.30);
            //myNumbers.Add(true);

            //foreach (var item in myNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            //here we can keep on adding, no restriction about data type nor about the size
            #endregion

            #region List

            #region List of String
            //List<string> techList = new List<string>();
            //techList.Add(".Net");
            //techList.Add("Angular");
            //techList.Add("Azure");
            //techList.Add("React");
            //techList.Add("AWS");
            //techList.Add("SQL Server");
            //techList.Add("Node");
            //techList.Add("Bootstrap");

            //foreach (var item in techList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List of Int
            //List<int> myNumbers = new List<int>();
            //myNumbers.Add(10);
            //myNumbers.Add(20);
            //myNumbers.Add(30);
            //myNumbers.Add(40);
            #endregion

            #region List of Products

            //List<Products> pList = new List<Products>();
            //pList.Add(new Products() { pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50});
            //pList.Add(new Products() { pId = 102, pName = "Coke", pCategory = "Cold-Drink", pIsInStock = true, pPrice = 50 });
            //pList.Add(new Products() { pId = 103, pName = "Latte", pCategory = "Hot-Drink", pIsInStock = false, pPrice = 50 });
            //pList.Add(new Products() { pId = 104, pName = "Mocha", pCategory = "Hot-Drink", pIsInStock = false, pPrice = 50 });
            //pList.Add(new Products() { pId = 105, pName = "IPhone", pCategory = "Electronics", pIsInStock = true, pPrice = 50 });
            //pList.Add(new Products() { pId = 106, pName = "Trailhawk", pCategory = "SUV", pIsInStock = false, pPrice = 50 });
            //pList.Add(new Products() { pId = 107, pName = "Fossil", pCategory = "Electronics", pIsInStock = true, pPrice = 50 });

            //foreach (var item in pList)
            //{
            //    if (item.pIsInStock)
            //    {
            //        Console.WriteLine(item.pId);
            //        Console.WriteLine(item.pName);
            //        Console.WriteLine(item.pCategory);
            //        Console.WriteLine(item.pPrice);
            //        Console.WriteLine(item.pIsInStock);
            //        Console.WriteLine("-----------------------------------------");
            //    }

            //}
            #endregion

            #endregion

            #region Sorted List - Non generic
            //SortedList myList = new SortedList();
            //myList.Add("P", "Pepsi");
            //myList.Add("D", "Dukes");
            //myList.Add("C", "Coke");
            //myList.Add("B", "Browser");
            //myList.Add("A", "Apple");
            //myList.Add("E", "Elephant");
            //myList.Add("CH", "Charger");
            //myList.Add("Age", 10);
            //myList.Add("isPermenant", true);

            //foreach (var item in myList.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region  Sorted List - Generic 
            //SortedList<int, string> myList = new SortedList<int, string>();

            //myList.Add(90, "Ninety");
            //myList.Add(10, "Ten");
            //myList.Add(20, "Twenty");
            //myList.Add(5, "Five");

            //foreach (var item in myList.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Hashtable
            //Hashtable ht = new Hashtable();
            //ht.Add(10, "Ten");
            //ht.Add("One", "One");

            //foreach (int item in ht.Keys)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Dictionary 
            //Dictionary<int, Products> pList = new Dictionary<int, Products>();

            //pList.Add(101,new Products() { pId=101, pName="Pepsi"});
            //pList.Add(102, new Products() { pId = 102, pName = "Coke" });
            //pList.Add(103, new Products() { pId = 103, pName = "Fanta" });
            //pList.Add(104, new Products() { pId = 104, pName = "Fossil" });
            //pList.Add(105, new Products() { pId = 105, pName = "IPhone" });
            //pList.Add(106, new Products() { pId = 106, pName = "Dell" });
            //pList.Add(107, new Products() { pId = 107, pName = "Airpods pro" });

            //foreach (var item in pList)
            //{
            //    Console.WriteLine(item.Key +  " " + item.Value.pName);
            //}
            #endregion

        }
    }
}





