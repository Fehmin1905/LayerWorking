using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGradeService
    {
        List<Grade> GetAll();
        Grade GetById(int id);
        void Add(Grade grade);
        void Update(Grade grade);
        void Delete(int id);
        List<Grade> GetForGradeDto();

    }
}
