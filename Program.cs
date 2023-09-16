using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            EmployeeCrud crud = new EmployeeCrud();
            do
            {
                Console.WriteLine("1.Show Employee Details");
                Console.WriteLine("2.Search Employee By ID");
                Console.WriteLine("3.Add Employee Details");
                Console.WriteLine("4.Update Employee Details");
                Console.WriteLine("5.Delete Employee Details");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        List<Employee> list1 = crud.ShowEmployee();
                        foreach (Employee emp in list1)
                        {
                            Console.WriteLine($"{emp.Id}\t{emp.Name}\t{emp.Salary}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Id Of Employee");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Employee emp2 = crud.SearchEmployee(id);
                        Console.WriteLine($"{emp2.Id}\t{emp2.Name}\t{emp2.Salary}");
                        break;
                    case 3:
                        Employee emp3 = new Employee();
                        Console.WriteLine("Enter ID");
                        emp3.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        emp3.Name = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        emp3.Salary = Convert.ToInt32(Console.ReadLine());
                        crud.AddEmployee(emp3);
                        break;
                    case 4:
                        Employee emp5 = new Employee();
                        Console.WriteLine("Enter Id");
                        emp5.Id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Employee Name");
                        emp5.Name = Console.ReadLine();
                        Console.WriteLine("Enter Employee Salary");
                        emp5.Salary = Convert.ToInt32(Console.ReadLine());
                        crud.UpdateRecord(emp5);
                        Console.WriteLine("UPDATED");
                        break;
                    case 5:
                        Employee emp4 = new Employee();
                        Console.WriteLine("Enter ID to Remove Record");
                        int id3 = Convert.ToInt32(Console.ReadLine());
                        crud.RemoveRecord(id3);
                        Console.WriteLine("Removed");
                        break;
                }
                Console.WriteLine("Press 1 if you want to Continue");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 1);
        }
    }
}
        
    

