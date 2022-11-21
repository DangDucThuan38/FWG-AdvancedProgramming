
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class School
    {
        // attribute: List<Student> students
        private List<Student> students;



        // default constructor
        public School()
        {
            students = new List<Student>();
        }

        // Enroll(): enroll student
        public void Enroll()
        {
            System.Console.Write("Enter name Student: ");
            string name=Console.ReadLine();
            System.Console.Write("Enter Age: ");
            int age=int.Parse(Console.ReadLine());
            System.Console.Write("Enter Grade: ");
            double grade=double.Parse(Console.ReadLine());

            Student s=new Student(name, age, grade);
            students.Add(s);
        }

        // DropOupt(): drop out student
        public void DropOut()
        {
            System.Console.Write("Enter ID: ");
            int ID=int.Parse(Console.ReadLine());

            Student s= FindByID(ID);

            if(s==null)
            {
                System.Console.WriteLine("Student not found");
            }else
            {
                students.Remove(s);
                System.Console.WriteLine("Student removed successfully");
            }
        }

        public Student FindByID(int ID)
        {
            foreach(Student s in students)
            {
                if(s.ID==ID)
                return s;
            }
            return null;
        }


        // ShowStudents(): show all students   

        public void ShowStudents()
        {
            System.Console.WriteLine("List Student");
            foreach (Student s in students)
            {
                s.ShowInfor();
                
            }
        }
    }
}