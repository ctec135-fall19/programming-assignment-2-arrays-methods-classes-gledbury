/*
Author: George Ledbury
Date: 10/12/2019
CTEC 135 Microsoft Software Development with C#

Module 3, Programming Assignment 2:Coding Projects, Problem 3 

    Class

Region 1: create a student class,
          * create a name field
          * create ID property
          * create automatic property for GPA
          * create a master constructor
          * create a constructor that has params forname, id, and uses chaining
          * create a default constructor
          * code a PrintState() method

*/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass

{
    class Program
    {
        static void Main(string[] args)
        {
            /* instantiate the object
            Student s = new Student();

            s.studentName = "George Ledbury";
            s.studentID = 123456;
            s.studentGPA = 4.0;
            s.PrintState();
            Console.WriteLine();

            Student s2 = new Student("Mr Magoo");
            s2.PrintState();
            Console.WriteLine();

            Student s3 = new Student("sam, 654321, 3.8");
            s3.PrintState();
            */

            Student s = new Student();
            s.PrintState();
            Console.WriteLine();

            Student s2 = new Student("Mr. Magoo");
            s2.PrintState();
            Console.WriteLine();

            Student s3 = new Student("Mickey Mouse");
            s3.PrintState();  
        }
    }
}
