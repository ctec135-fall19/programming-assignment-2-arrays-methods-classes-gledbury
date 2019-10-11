/*
Author: George Ledbury
Date: 10/11/2019
CTEC 135: Microsoft Software Development with C#

Module 3, Programming Assignment 2, Project 1

    Arrays

1. Region 1: array of Strings. 
            -create an array of strings of the first ten
             whole numbers.
            -initialize the array
            -print the array using a foreach loop.

2. Region 2: array of ints.
            -create an array of ints of size 10.
            -initialize the array using a for loop with the values
             being the index multiplied by 10.
            -print the array using a for loop.

3. Region 3: 2-D array.
            -create a 2-D array that holds the values of the multiplication table up to 12x12.
            -initialize the array
            -print the array nicely formatted
            
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1: array of strings
            // create array of strings
            string[] strArray = new string[] {"one", "two", "three", "four",
             "five", "six", "seven", "eight", "nine", "ten"};

            Console.WriteLine("The elements of the array are:\n");
            // initialize the array
            foreach (string s in strArray)
            {
            // print the array
                Console.WriteLine(s);
                Console.WriteLine();
            }
            #endregion

            #region 2: array of ints
            // creata an array of ints. the array is size 10
            int[] myInts = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine
                ("The indexes of the array multiplied by 10 are:\n");

            // initialize with a for loop with the values of the index
            // multiplied by 10
            int i;
            for (i = myInts[0]; i <= myInts.Length; i++)
            {
                myInts[0] = i;
                // printthe array
                Console.WriteLine(i * 10);
            }
            #endregion

            Console.WriteLine("\n\n");

            #region 3: 2-D array
            // create a 2-D array that holds a multiplication table of 12x12
            int[,] array2D = new int[13,13];

            // just formatting for bonus points
            Console.WriteLine("\t\t\t\t12 X 12 Multiplication Table");
            
            for (int topNumber = 1; topNumber <= 12; topNumber++)
            {
                Console.Write("\t" + topNumber);
            }
            Console.WriteLine("\n------------------------------------------" +
                "----------------------------------------------------------");
        
            // initialize the array with nested for loops
            for (int x = 1; x <= 12; x++)
            {
                Console.Write(x + ":\t");
                for (int y = 1; y <= 12; y++)
                {   
                    // perform the multiplication
                    array2D[x, y] = x * y;
                    Console.Write("{0}\t", array2D[x,y]);
                 
                }
                Console.WriteLine();  
            }
            #endregion
        }
    }
}
