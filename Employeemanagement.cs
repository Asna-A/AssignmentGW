using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementt
{
    public class Employee
    {
        private static int count = 1000;
        public string Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id)
        {
            count++;
            Id = "Emp" + (1000+id);
        }
        public Employee(int id, string name) : this(id)
        {
            Name = name;
        }

        public Employee(int id, string name, double salary) : this(id, name)
        {
            Salary = salary;
        }
        public void display()
        {
            Console.WriteLine(Id + " " + Name + " " + Salary);
        }
        public static void displaynumberofemployees()
        {
            Console.WriteLine("number of employees " + (count-1000));
        }
        internal class Program
        {
            static void Main(string[] args)
            {

                Employee e1 = new Employee(1, "John Doe", 15000);
                Employee e2 = new Employee(2, "Liam Smith", 20000);
                Employee e3 = new Employee(3, "Mary James", 15000);
                e1.display();
                e2.display();
                e3.display();
                Employee.displaynumberofemployees();
                Console.ReadLine();

            }
        }
    }
}
