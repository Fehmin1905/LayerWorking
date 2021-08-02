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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {

            _studentDal.Add(student);

        }

        public void Delete(int id)
        {
            var student = _studentDal.Get(s => s.Id == id);

            _studentDal.Delete(student);
        }

        public Student GetById(int id)
        {
            return _studentDal.Get(s => s.Id == id);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        public List<Student> GetForDto()
        {
            return _studentDal.GetAllForDto();
        }
    }
}
