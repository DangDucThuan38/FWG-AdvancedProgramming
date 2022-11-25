using System.Runtime.InteropServices;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class School
    {
        private List<BtecStudent> btecStudents;
        private List<TopupStudent> topupstudents;

        public School()
        {
            btecStudents = new List<BtecStudent>();
            topupstudents = new List<TopupStudent>();
        }
        public void PrinMenu()
        {
            System.Console.WriteLine("1.Add new Student");
            System.Console.WriteLine("2.Move to Student");
            System.Console.WriteLine("3.Show Btec Students");
            System.Console.WriteLine("4.Show Topup Students");
            System.Console.WriteLine("5.Grade Btec");
            System.Console.WriteLine("6.Grade Topup");
            System.Console.WriteLine("0.Exit!");
        }
        public int GetChoice()
        {
            System.Console.Write("Your choice:");
            int choice = int.Parse(System.Console.ReadLine());
            return choice;
        }

        public void Enroll()
        {
            System.Console.Write("Name Student:");
            string name = Console.ReadLine();
            System.Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());

            BtecStudent btec = new BtecStudent(name, age);
            btecStudents.Add(btec);

        }
        private void MoveToToup()
        {
            // enter btec student id
            System.Console.WriteLine("Enter Student ID: ");
            string id = Console.ReadLine();
            //find the student by id in btecStdudents list
            foreach (BtecStudent btec in btecStudents)
            {
                if (btec.ID == id)
                {
                    TopupStudent ts= new TopupStudent(btec.Name,btec.Age);
                    topupstudents.Add(ts);
                    btecStudents.Remove(btec);
                    return;
                }
            }
            System.Console.WriteLine("BTEC student ID "+id+"not found");



            //create topupstudents object based ont the student btec object
            //add thetopup students object to topupstudents list

        }
        private void GradeBtecStudents()
        {
            foreach (BtecStudent btec in btecStudents)
            {
                System.Console.WriteLine("Enter grade for Student"+btec.Name+":");
                string grade= Console.ReadLine();
                btec.Grade= grade;
                
            }

        }
        private void GradeTopupStudent()
        {
            foreach(TopupStudent tp in topupstudents)
            {
                System.Console.WriteLine("Enter grade for Student "+ tp.Name+";");
                int grade= int.Parse(Console.ReadLine());
                tp.Grade=grade;
                System.Console.WriteLine("Enter OJT Result:");
                string ojt= Console.ReadLine();
                tp.Ojt=ojt;
            }
        }

        public void Process(int choice)
        {
            switch (choice)
            {
                case 1: Enroll(); break;
                case 2: MoveToToup(); break;
                case 3: ShowBtecStduent(); break;
                case 4: ShowTopupStudent(); break;
                case 5 : GradeBtecStudents(); break;
                case 6 : GradeTopupStudent(); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid choice"); break;
            }

        }
        public void ShowBtecStduent()
        {
            foreach (BtecStudent bt in btecStudents)
            {
                bt.ShowInfo();
                
            }
        }
        public void ShowTopupStudent()
        {
            foreach (TopupStudent ts in topupstudents)
            {
                ts.ShowInfo();
                
            }

        }
    }
}