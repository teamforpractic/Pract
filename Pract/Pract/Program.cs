using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pract
{
    class Program:Mas
    {
        static void Main(string[] args)
        {
            Array.Copy(nums1, 0, nums2, 0, 5);
            Array.Reverse(nums2);
            if (nums1.Length == nums2.Length)
            {
                for (int i = 0; i < nums1.Length; )
                {
                    if (nums1[i] == nums2[i])
                    {
                        i++;
                        if (i == 5)
                        {
                            Console.WriteLine("==");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            Console.ReadLine();
        }

    }

    class Mas
    {
        protected static int[] nums1 = {1, 2, 3, 2, 1};
        protected static int[] nums2 = new int[5];


    }
}    

