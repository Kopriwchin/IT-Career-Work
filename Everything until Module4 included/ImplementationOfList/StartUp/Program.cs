using System;
using System.Collections.Generic;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();

            list.Add(5);
            list.Add(3);
            list.Add(1);
            list.RemoveAt(0);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
