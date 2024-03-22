using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyde.Core.Models
{
     public class Punkts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public List<EmployeePunkts> employeePunkts { get; set; }
        
    }
}
