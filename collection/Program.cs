using System;
using System.Collections;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList() { 1, 2,3,4,5,-6,-7,-8,-9,-10 };
            List.Add(5.8);
            foreach (object o in List)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("число элементов коллекции: {0}", List.Count);
        }
    }
}
