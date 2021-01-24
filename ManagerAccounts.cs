using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAndClosePrinciple
{
    //set up Manager accounts to inherit from IAccounts, that way I can hire managers without modifying any code from the accounts class.
    //I'm very grateful for interfaces
    public class ManagerAccounts : IAccounts
    {
        
        public Employee HiringProcess(IPerson applicant)
        {
            Employee employee = new Employee();
            employee.FirstName = applicant.FirstName;
            employee.LastName = applicant.LastName;
            employee.Email = applicant.FirstName + applicant.LastName + "@company.com";

            employee.IsManager = true;

            return employee;
        }
    }
}
