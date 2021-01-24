using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAndClosePrinciple
{
    //Similar to the other accounts, this turns regular ol' people into executives.
    class ExecutiveAccounts : IAccounts
    {
        public Employee HiringProcess(IPerson applicant)
        {
            Employee employee = new Employee();
            employee.FirstName = applicant.FirstName;
            employee.LastName = applicant.LastName;
            employee.Email = applicant.FirstName + applicant.LastName + "@company.com";

            employee.IsManager = true;
            employee.IsExecutive = true;

            return employee;
        }
    }
}
