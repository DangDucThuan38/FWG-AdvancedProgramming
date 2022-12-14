using EmployeeManagement;


List<Candidate> candidates= new List<Candidate>();

candidates.Add(new Candidate("John",30,8.0) );
candidates.Add(new Candidate("Jame",31,7.0));
candidates.Add( new Candidate("Paul",26,5.5));
candidates.Add( new Candidate("Ronaldo",30,9.0));
candidates.Add( new Candidate("Ramo",35,8.0));


HRDepartment hr= new ITHRDepartment();
List<Employee> employees= hr.Recruit(candidates);

System.Console.WriteLine("Conratulation ");
foreach (Employee e in employees)
{
    System.Console.WriteLine(e.ToString());
    
}

