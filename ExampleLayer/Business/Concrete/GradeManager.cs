using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GradeManager : IGradeService
    {
        IGradeDal _gradeDal;

        public GradeManager(IGradeDal gradeDal)
        {
            _gradeDal = gradeDal;
        }

        public void Add(Grade grade)
        {
            _gradeDal.Add(grade);
        }

        public void Delete(int id)
        {
            var deletedGrade = _gradeDal.Get(g => g.Id == id);
            _gradeDal.Delete(deletedGrade);
        }

        public Grade GetById(int id)
        {
            return _gradeDal.Get(g => g.Id == id);
        }

        public List<Grade> GetAll()
        {
            return _gradeDal.GetAll();
        }

        public void Update(Grade grade)
        {
            _gradeDal.Update(grade);
        }

        public List<Grade> GetForGradeDto()
        {
            return _gradeDal.GetAllForDto();

        }
    }
}
