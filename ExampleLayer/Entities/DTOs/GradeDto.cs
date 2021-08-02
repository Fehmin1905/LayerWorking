using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GradeDto:IDto
    {
        public int GradeName { get; set; }
        public bool GradeRate { get; set; }
        public Student Student { get; set; }

    }
}
