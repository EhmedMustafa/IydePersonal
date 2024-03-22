using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyde.Core.Models
{
    public class Employees
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPosition { get; set; }
        public string shop { get; set; }
        public bool Active { get; set; }
        public int SalaryId { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime FinishWork { get; set; }
        public int UserId { get; set; }
        public List<EmployeePunkts> employeePunkts { get; set; }
        public Salary Salary { get; set; }

        public Users Users { get; set; }



    }
}
