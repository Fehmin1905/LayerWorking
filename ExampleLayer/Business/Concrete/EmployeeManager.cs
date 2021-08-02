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
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void Delete(int id)
        {
            var result = _employeeDal.Get(p => p.Id == id);
            _employeeDal.Delete(result);
        }

        public Employee GetById(int id)
        {
           return _employeeDal.Get(p=>p.Id==id);
        }


        //---------------------
        public List<Employee> GetAll()
        {
            var result = _employeeDal.GetAll();

            return result;
        }


        public void Update(Employee employee)
        {
            _employeeDal.Update(employee);
        }

        public List<EmployeeDto> GetForDto()
        {
            return _employeeDal.GetAllDataDto();
        }
    }
}
