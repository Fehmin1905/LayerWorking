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
    public class EmployeesController : ControllerBase
    {
        IEmployeeService _employeeService;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        [HttpGet("GetEmployeeDto")]
        public IActionResult GetEmployeeDto()
        {
            var employee = _employeeService.GetForDto();
            var result= _mapper.Map<List<EmployeeDto>>(employee);
            return Ok(result);
        }



        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_employeeService.GetById(id));
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            _employeeService.Add(employee);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return Ok();
        }


        [HttpPut]
        public IActionResult Update(Employee employee)
        {
            _employeeService.Update(employee);
            return Ok();
        }
    }
}
