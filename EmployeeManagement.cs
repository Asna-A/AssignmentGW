using System;
public class EmployeeManagement
{
    public int ID { get; private set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Employeetype { get; set; }
    public EmployeeManagement(int ID, string Name, double Salary, string Employeetype)
    {
        this.ID = ID;
        this.Name = Name;
        this.Salary = Salary;
        this.Employeetype = Employeetype;
    }
    public void display()
    {
        Console.WriteLine("employee id:"+ID);
        Console.WriteLine("employee name:" + Name);
        Console.WriteLine("employee salary:" + Salary);
    }

}
public class Program
{
    public static void Main(string[] args)
    {
        EmployeeManagement e1 = new EmployeeManagement(1, "John Doe", 15000,"Permanent");
        EmployeeManagement e2 = new EmployeeManagement(1, "John Doe", 15000, "Permanent");
        EmployeeManagement e3 = new EmployeeManagement(1, "John Doe", 15000, "Permanent");
        e1.display();
        e2.display();
        e3.display();

    }
}
