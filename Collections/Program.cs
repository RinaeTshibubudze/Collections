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

        }
    }
}