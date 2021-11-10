using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using Solutions;

namespace Project1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 5, 9, 3, 1, 6, 4, 7};
            QuickSort.sort(array);
            Console.WriteLine(String.Join(",", array));
            Console.ReadKey();
        }

        
    }
}
