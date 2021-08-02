using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using WebApi.Controllers;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1
    {
        public Mock<IDepartmentService> mock = new Mock<IDepartmentService>();
        DepartmentsController _controller;
        IDepartmentService _service;

        public UnitTest1(DepartmentsController controller, IDepartmentService service)
        {
            _controller = controller;
            _service = service;
        }

        [Fact]
        public void Get()
        {
            var result = _controller.GetAll();
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
