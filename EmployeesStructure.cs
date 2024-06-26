using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStructure
{
    public class EmployeesStructure
    {
        public EmployeesStructure? Superior { get; set; }
        public int EmployeeId { get; set; }

        public EmployeesStructure(Employee e)
        {
            EmployeeId = e.Id;
            if(e.Superior != null)
                Superior = new EmployeesStructure(e.Superior);
        }
        public int? GetEmployee(int id, int i)
        {
            if(EmployeeId == id)
                return i;

            if(Superior != null)
                return Superior.GetEmployee(id, ++i);

            return null;
        }
        
    }
}
