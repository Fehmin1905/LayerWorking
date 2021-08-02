using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Grade:IEntity
    {
        public int Id { get; set; }
        public int GradeName { get; set; }
        public bool GradeRate { get; set; }
        public int StudentId { get; set; }
        [JsonIgnore]
        public Student Student { get; set; }
    }
}
