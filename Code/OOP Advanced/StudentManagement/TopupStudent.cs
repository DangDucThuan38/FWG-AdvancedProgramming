using System;


namespace StudentManagement
{
    public class TopupStudent: Student
    {
        private int  grade;
        public int Grade
        {
            get{return grade;}
            set
            {
                if(value >= 100 || value<0) grade = 0;
                else grade= value;
            }
        }
        private string ojt;
        public string Ojt
        {
            get {return ojt;}
            set
            {
                if(value !="Pass" && value !="Fail")
                {
                    ojt="Fail";
                }
                else ojt=value;
            }
        }
        public  TopupStudent()
        {
            grade=50;
            ojt="Fail";
        }
        public TopupStudent(string name,int age):base(name,age)
        {
            Grade = 0;
            Ojt= "Fail";
        }
        public void ShowInfor()
        {
            base.ShowInfo();
            System.Console.WriteLine("Grade Topup:"+Grade+" ,OJT:"+Ojt);
        }
        
    }
}