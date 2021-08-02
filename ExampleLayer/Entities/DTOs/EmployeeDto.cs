using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class EmployeeDto:IDto
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        [JsonIgnore]
        public Department Department { get; set; }
    }
}
