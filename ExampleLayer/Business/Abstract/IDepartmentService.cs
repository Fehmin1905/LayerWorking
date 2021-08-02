using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        void Add(Department department);
        Department GetById(int id);
        void Update(Department department);
        void Delete(int id);
    }
}
