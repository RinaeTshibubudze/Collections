using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Array List Code
             */

            var arrayList = new ArrayList();
            arrayList.Add(7);
            arrayList.Add(5);
            arrayList.Add(4);
            arrayList.Add(2);
            arrayList.Add(3);

            Console.WriteLine("The Initial list");

            foreach (var v in arrayList)
            {
                Console.Write(v + " ");   
            }

            // Sort array list
            Console.WriteLine();
            Console.WriteLine("Sort Array List");
            arrayList.Sort();

            foreach (var srt in arrayList)
            {
                Console.Write(srt + " ");
            }

            // Reverse an array list
            Console.WriteLine();
            Console.WriteLine("Reversed Array List");
            arrayList.Reverse();

            foreach (var rvrs in arrayList)
            {
                Console.Write(rvrs + " ");
            }

            /*
             HashTable Code
                */

            var hashtbl = new Hashtable();

            hashtbl.Add("Number", 1);
            hashtbl.Add("Car", "Ferrari");
            hashtbl.Add(8, "eight");

            var value1 = (int)hashtbl["Number"]!;
            var value2 = (string)hashtbl["Car"]!;
            var value3 = (string)hashtbl[8]!;

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            //now we remove a key

            hashtbl.Remove(8);

            //Lets try to find the remove key now

            var valueRemoved = (string)hashtbl[8]!;
            Console.WriteLine("The value of the given key is :" + valueRemoved);

            // clearing all data from the HashTable
            hashtbl.Clear();


            /*
              
            Sorted List Code
            */
            var sortedList = new SortedList();
            sortedList.Add(2, "Two Pineapples");
            sortedList.Add(4, "Four Apples");
            sortedList.Add(3, "Three Lemons");
            sortedList.Add(5, "Five Mangoes");
            sortedList.Add(1, "One Tree");

            string i = (string)sortedList[1]!;
            string j = (string)sortedList[5]!;
            string k = (string)sortedList[3]!;

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            //boolean value for key 5
            bool key = sortedList.ContainsKey(5);

            //boolean value for vlaue "One Tree"
            bool val = sortedList.ContainsValue("One Tree");

            //Boolean value for unavailable key
            bool unKey = sortedList.ContainsKey(25);

            //Boolean value for unavailable value
            bool unVal = sortedList.ContainsValue("some randome value");
            Console.WriteLine("The sorted list contains 5 key :" + key);
            Console.WriteLine("The sorted list contains One Tree value :" + val);
            Console.WriteLine("The sorted list contains 25 key :" + unKey);
            Console.WriteLine("The sorted list contains some randome value:" + unVal);

            //The Remove() method accepts key as argument and removes both the key and the value
            sortedList.Remove(1);

            //Now we will check if the key is present
            bool rmvKey = sortedList.ContainsKey(1);
            Console.WriteLine("The presence if the key is: " + rmvKey);

            //The RemoveAt() method acceots index as argument and remove any key and value present at that index
            sortedList.RemoveAt(3);
            Console.ReadLine();

        }
    }
}