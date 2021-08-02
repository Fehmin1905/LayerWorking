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
    public class GradeDal:EntityRepositoryBase<Grade,EfCoreDbContext>,IGradeDal
    {
        private readonly EfCoreDbContext _dbContext;

        public GradeDal(EfCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Grade> GetAllForDto()
        {
            var result = _dbContext.Grades.Include(x => x.Student).ToList();
            return result;
        }
    }
}
