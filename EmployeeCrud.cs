using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEmployee
{
    internal class EmployeeCrud
    {

            private List<Employee> emplist;

            public EmployeeCrud()
            {
                emplist = new List<Employee>()
            {
                new Employee(){Id=401,Name="Ali",Salary=40000},
                 new Employee(){Id=402,Name="Suyash",Salary=80000},
                  new Employee(){Id=404,Name="Amay",Salary=40000},
            };
            }

            public List<Employee> ShowEmployee()
            {
                return emplist;
            }

            public Employee SearchEmployee(int id)
            {
                Employee emp = new Employee();
                foreach (Employee item in emplist)
                {
                    if (item.Id == id)
                    {

                        emp = item;
                        break;
                    }

                }
                return emp;
            }

            public void AddEmployee(Employee e1)
            {
                emplist.Add(e1);

            }

            public void RemoveRecord(int id)
            {
                Employee e = new Employee();
                foreach (Employee item in emplist)
                {
                    if (item.Id == id)
                    {
                        emplist.Remove(item);
                        break;
                    }
                }
            }

            public void UpdateRecord(Employee e)
            {

                foreach (Employee item in emplist)
                {
                    if (item.Id == e.Id)
                    {
                        item.Name = e.Name;
                        item.Salary = e.Salary;
                        break;
                    }
                }
            }
    }
}




