/*
Author: George Ledbury
Date: 10/12/2019
CTEC 135 Microsoft Software Development with C#

Module 3, Programming Assignment 2:Coding Projects, Problem 2

    Methods

Region 1: Create a static method that demonstrates a call by value.
Region 2: Create a static method that demonstrates a call by reference.
Region 3: Create a static method that demonstrates method overloading.

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region: 1 method call by value
            string[] strArray = new string[] { "This", "Is", "Problem", "Two" };
            int num = 50;

            // print values before method call
            Console.WriteLine("Values before method call");
            Console.WriteLine("num: {0}", num);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nPress Enter");
            // call method
            myMethod(num, strArray);
            Console.ReadLine();

            //print values after method call
            Console.WriteLine("values after method call");
            Console.WriteLine("num: {0}", num);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            #endregion

            // method overloading
            myMethod(strArray);

            //print values
            Console.WriteLine("values after method call");
            Console.WriteLine("num: {0}", num);
            foreach (string s in strArray)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();


        }
        // method that demonstrates the call by value and reference
        static void myMethod(int arg1, string[] arg2)
        {
            arg1 = 12345;
            arg2[1] = "is after the method call for";
        }
        
        static void myMethod(string[] arg2)
        {
            arg2[0] = "One-Hundred";
        }
    }
    
}
