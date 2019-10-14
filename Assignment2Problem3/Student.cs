using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        /*field
        public string studentName;
        // properties
  
        public string GetStudentName() { return studentName; }

        public void SetStudentName(string name)
        {
            //perform name validation
            if (name.Length > 15) { studentName = name.Substring(0, 15);}
            else studentName = name;
        }

        public int studentID; 
        // automatic properties
        public double studentGPA { get; set; }

                   
        // student ID getter/setter
        public int GetStudentID() { return studentID;}

        public void SetStudentID(int setStudentID) { setStudentID =
                studentID;}

        // constructors (with chaining example)
        // master constructor
        public Student( string student, int id, double gpa)
        {
            studentName = student;
            studentID = id;
            studentGPA = gpa;
        }
        
        public Student() : this("none", 0, 0.0){}

        public Student(string student) : this(student, 0, 0.0) {}


        //methods
        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", studentName);
            Console.WriteLine("ID:\t{0}", studentID);
            Console.WriteLine("GPA:\t{0:0.00}", studentGPA);
        }
        */
        // field
        private string stuName;
        // properties
        public string Name
        {
            get { return stuName; }
            set
            {
                // perform validation
                if (value.Length > 15) { stuName = value.Substring(0, 15); }
                else stuName = value;
            }
        }
        // automatic properties
        public int StudentID { get; set; }
        public double Gpa { get; set; }
        // constructors
        // master
        public Student(string name, int id, double gpa)
        {
            Name = name;
            StudentID = id;
            Gpa = gpa;
        }
        public Student() : this( "Donald Duck", 121212, 4.0) { }

        public Student(string name) : this(name, 654321, 2.8) { }

        // methods
        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", stuName);
            Console.WriteLine("Name:\t{0}", Name);
            Console.WriteLine("ID:\t{0}", StudentID);
            Console.WriteLine("GPA:\t{0:0.00}", Gpa);
        }
    }
}
