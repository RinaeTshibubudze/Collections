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

            var value1 = (int)hashtbl["Number"];
            var value2 = (string)hashtbl["Car"];
            var value3 = (string)hashtbl[8];

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            //now we remove a key

            hashtbl.Remove(8);

            //Lets try to find the remove key now

            var valueRemoved = (string)hashtbl[8];
            Console.WriteLine("The value of the given key is :" + valueRemoved);

            // clearing all data from the HashTable
            hashtbl.Clear();
        }
    }
}