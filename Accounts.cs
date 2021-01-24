using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenAndClosePrinciple
{
    //the Accounts class that started it all. This is the class I based my interface from
    //the goal of this class is to turn People into Employess. HOPEFULLY I can undergo the same process. ;)
    public class Accounts : IAccounts
    {
        public Employee HiringProcess(IPerson applicant)
        {
            Employee employee = new Employee();
            employee.FirstName = applicant.FirstName;
            employee.LastName = applicant.LastName;
            employee.Email = applicant.FirstName + applicant.LastName + "@company.com";



            return employee;
        }
    }
}
