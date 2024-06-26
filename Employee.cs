using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeStructure
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SuperiorId { get; set; }
        public virtual Employee Superior { get; set; }

        public Employee(int id, string name, int? superiorId)
        {
            Id = id;
            Name = name;
            SuperiorId = superiorId;
        }
    }
}
