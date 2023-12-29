// See https://aka.ms/new-console-template for more information
using HR;

Console.WriteLine("Hello, World!");

Person person1 = new Person(34,"Ishan", 22);
Person person2 = new Person();
person2.Id = 91;
person2.Name = "Shadaab";
person2.Age = 23;
Console.WriteLine(person1);

Console.WriteLine(person2);

Employee employee1 = new Employee();
employee1.Id = 101;
employee1.Name = "Shriram";
employee1.Age = 24;
employee1.BasicSalary = 45000;
employee1.DailyAllowance = 3000;
employee1.Deductions = 6000;

Console.WriteLine(employee1);