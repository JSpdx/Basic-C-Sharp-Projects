using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            List<string> intList = new List<string>();         
            intList.Add("hi");
            intList.Add("whats up");
            intList.Add("not much");
            intList.Remove("not much");
            
            Console.WriteLine(intList[1]);
            Console.ReadLine();

            
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;



            //int[] numArray1 = new int[] { 5, 5, 10, 200, 5000 };

            //int[] numArray2 = { 5, 4, 10, 200, 5000, 45, 456, 234 };
            //numArray2[5] = 670;
            //Console.WriteLine(numArray2[5]);
            //Console.ReadLine();


        }
    }
}