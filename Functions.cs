using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStructure
{
    public class Functions
    {
        public List<EmployeesStructure> emp = new List<EmployeesStructure>();
        public List<EmployeesStructure> FillEmployeesStructure(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                emp.Add(new EmployeesStructure(employee));
            }

            return emp;
        }

        public int? GetSuperiorRowOfEmployee(int employeeId, int superiorId)
        {
            var employee = emp.Find(e => e.EmployeeId == employeeId);
            if(employee != null)
                return employee.GetEmployee(superiorId, 0);

            return null;
        }
    }
}
