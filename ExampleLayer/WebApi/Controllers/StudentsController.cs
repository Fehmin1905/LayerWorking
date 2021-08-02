using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IStudentService _studentService;
        IMapper _mapper;
        public StudentsController(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_studentService.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_studentService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            _studentService.Add(student);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Student student)
        {
            _studentService.Update(student);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return Ok();
        }


        [HttpGet("GetStudentForDto")]
        public IActionResult GetStudentForDto()
        {
            var student = _studentService.GetAll();
            var result = _mapper.Map<List<StudentDto>>(student);
            return Ok(result);
        }
    }
}
