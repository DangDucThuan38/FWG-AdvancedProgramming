using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class ITHRDepartment: HRDepartment
    {
        protected override List<Candidate> CVRound(List<Candidate> candidates)
        {
            List<Candidate> passCV= new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                if(c.Age >=18 && c.Age<=30 && c.GPA>=6.0)
                {
                    passCV.Add(c);
                    System.Console.WriteLine("Candidate "+c.Name+"passsed CV Round!");

                }
                
            }
            return passCV;
        }
        protected override List<Candidate> TestRound(List<Candidate> candidates)
        {
             List<Candidate> passTest= new List<Candidate>();
            foreach (Candidate c in candidates)
            {
                System.Console.WriteLine("Candidate "+c.Name+" was asked do a coding changllenge.");
                System.Console.Write("Did candidate "+c.Name+" pass the test? (y/n): ");
                string answer= Console.ReadLine();
                if(answer=="y")
                {
                    passTest.Add(c);
                    System.Console.WriteLine("Candidate "+c.Name+" Pass TestRound !");
                }
                
            }
            return passTest;
        }
        protected override List<Candidate> InterviewRound(List<Candidate> candidates)
        {
            return candidates;
        }

        protected override Employee Offer(Candidate candidate)
        {
            System.Console.WriteLine("What is the salary for "+ candidate.Name +"? ");
            double salary= double.Parse(Console.ReadLine());
            System.Console.WriteLine("What is the Language "+candidate.Name +" can do? ");
            string lanuage =Console.ReadLine();

            DevEmployee employee= new DevEmployee(candidate.Name,candidate.Age,salary,lanuage);
            return employee;
        }
        
    }
}