using DemoComposite;

Company company= new Company();

ReferenceMember Jack = new ReferenceMember("Jack",100);
Jack.Add( new NormalMember("Anna",100));
Jack.Add( new NormalMember("Lauren",100));


ReferenceMember Mike= new ReferenceMember("Mike",100);
ReferenceMember Tom= new ReferenceMember("Tom",100);
Tom.Add(new NormalMember("Laura",100));
Tom.Add(new NormalMember("Windy",100));

Mike.Add(Tom);

Mike.Add( new NormalMember("Ax",100));
Mike.Add( new NormalMember("Lau",100));

ReferenceMember Paul= new ReferenceMember("Paul",100);
Paul.Add(new NormalMember("Henry",100));

company.AddTopMember(Jack);
company.AddTopMember(Mike);
company.AddTopMember(Paul);


company.Show();
System.Console.WriteLine("Total income: {0}", company.CalculateIncome());



