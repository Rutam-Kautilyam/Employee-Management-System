using EmployeeAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Tests
{
    public class EmployeeControllerTests
    {

        [Fact]
        public void GetEmployees_ReturnOkResult()
        {
            // Arrange
            var controller = new EmployeeController();

            // Act
            var result = controller.GetEmployees();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetEmployee_InvalidId_ReturnsNotFound()
        {
            // Arrange
            var controller = new EmployeeController();

            // Act
            var result = controller.GetEmployee(100);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
