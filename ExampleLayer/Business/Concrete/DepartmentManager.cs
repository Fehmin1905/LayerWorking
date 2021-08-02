using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Add(Department department)
        {
            _departmentDal.Add(department);
        }

        public void Delete(int id)
        {
            var result = _departmentDal.Get(b => b.Id == id);
            _departmentDal.Delete(result);
        }

        public Department GetById(int id)
        {
            return _departmentDal.Get(p=>p.Id==id);
        }

        public List<Department> GetAll()
        {
            return _departmentDal.GetAll();
        }

        public void Update(Department department)
        {
            _departmentDal.Update(department); 
        }

       
    }
}
