using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pract
{
    class Program
    {
        static int[] nums1 = { 1, 2, 3, 2, 1 };
        static void Main(string[] args)
        {
            for (var i = 0;nums1[i]==nums1[nums1.Length-i-1]; i++)
            {
                if (i == nums1.Length-1)
                {
                    Console.WriteLine("==");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}    

