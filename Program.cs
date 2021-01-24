using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAndClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a list of applicants
            List<IPerson> applicants = new List<IPerson>
            {
                new Executive {FirstName = "Tyler", LastName = "Carron"},
                new Person {FirstName = "Lacey", LastName = "Culvey"},
                new Manager {FirstName = "SeanO", LastName = "Robinson"}
            };
            List<Employee> employeePool = new List<Employee>();
            //turning people into employees
            foreach(var person in applicants)
            {
                employeePool.Add(person.AccountProcessor.HiringProcess(person));
            }
            //printing all employees
            foreach(var employee in employeePool)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + employee.Email+" Is Manager: "
                    +employee.IsManager+ " Is Executive: " + employee.IsExecutive);
            }
        }
    }
}
