using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Department:IEntity
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentArea { get; set; }
        [JsonIgnore]
        public List<Employee> Employees { get; set; }
    }
}
