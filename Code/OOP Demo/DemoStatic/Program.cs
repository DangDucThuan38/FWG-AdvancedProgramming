using DemoStatic;

Student s1 = new Student("Nguyen Van A", 20);
Student s2 = new Student("Nguyen Van B", 21);

s1.ShowInfor();
s2.ShowInfor();

Student.School = "Greenwich VietNam";
s1.ShowInfor();
s2.ShowInfor();
