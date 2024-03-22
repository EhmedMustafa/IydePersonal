using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyde.Core.Models
{
    public class EmployeePunkts
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int PunktId { get; set; }
        public DateTime CreateDate { get; set; }
        public Punkts punkts { get; set; }
        public Employees employees { get; set; }

    }
}
