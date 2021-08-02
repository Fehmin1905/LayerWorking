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
    public class StudentDal : EntityRepositoryBase<Student, EfCoreDbContext>, IStudentDal
    {
        EfCoreDbContext _dbContext;

        public StudentDal(EfCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> GetAllForDto()
        {
            return _dbContext.Students.ToList();
        }
    }
}
