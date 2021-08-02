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
    public class GradesController : ControllerBase
    {
        IGradeService _gradeService;
        IMapper _mapper;
        public GradesController(IGradeService gradeService,IMapper mapper)
        {
            _gradeService = gradeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_gradeService.GetAll());

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
             _gradeService.GetById(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Add(Grade grade)
        {
            _gradeService.Add(grade);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Grade grade)
        {
            _gradeService.Update(grade);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _gradeService.Delete(id);
            return Ok();
        }


        [HttpGet("GetGradeDto")]
        public IActionResult GetGradeDto()
        {
            var grade = _gradeService.GetForGradeDto();
            var result = _mapper.Map<List<GradeDto>>(grade);
            return Ok(result);
        }

        
    }
}
