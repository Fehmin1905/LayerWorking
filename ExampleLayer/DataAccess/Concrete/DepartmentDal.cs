using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DepartmentDal:EntityRepositoryBase<Department,EfCoreDbContext>,IDepartmentDal
    {
        private readonly EfCoreDbContext _dbContext;

        public DepartmentDal(EfCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Department> GetDepartmentDtos()
        {
            //var result= from p in _dbContext.Departments
            //            select new Department
            return _dbContext.Departments.ToList();

        }

      
    }
}
