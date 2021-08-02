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
    public class DepartmentsController : ControllerBase
    {
        IDepartmentService _departmentService;
        private readonly IMapper _mapper;
        public DepartmentsController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _departmentService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_departmentService.GetById(id));
        }


        [HttpPost]
        public IActionResult Add(Department department)
        {
            _departmentService.Add(department);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Department department)
        {
            _departmentService.Update(department);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _departmentService.Delete(id);
            return Ok();
        }

        [HttpGet("GetDepartmentDto")]
        public IActionResult GetDepartmentDto()
        {
            var department = _departmentService.GetAll();
            var result = _mapper.Map<List<DepartmentDto>>(department);
            return Ok(result);
        }
    }
}
