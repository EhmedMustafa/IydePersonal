using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyde.Core.Models
{
   public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employees> employees { get; set; }
    }
}
