using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EmployeDal : EntityRepositoryBase<Employee, EfCoreDbContext>, IEmployeeDal
    {
        private readonly EfCoreDbContext _dbContext;

        public EmployeDal(EfCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<EmployeeDto> GetAllDataDto()
        {
            //var result = _dbContext.Employees.Include(x => x.Department).ToList();
            var result = from e in _dbContext.Employees
                         join d in _dbContext.Departments
                         on e.DepartmentId equals d.Id
                         select new EmployeeDto
                         {
                             Id=e.Id,
                             EmployeeName=e.EmployeeName,
                             DepartmentName=d.DepartmentName
                         };
            return result.ToList();
        }

    }
}
