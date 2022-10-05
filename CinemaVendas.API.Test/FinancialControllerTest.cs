using CinemaVendas.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CinemaVendas.API.Test
{
    class FinancialControllerTest
    {
        private Mock<IFinancialsService> _mockService;
        private FinancialController _controller;

        public FinancialControllerTest()
        {
            _mockService = new Mock< IFinancialsService > ();
            _controller = new FinancialController(_mockService.Object);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(30.5)]
        [InlineData(-30.5)]
        [InlineData(-1)]

        public void GetTotalSold_HasAmount_RetunrOkResult(decimal total)
        {
            //arrange
            _mockService.Setup(service => service.GetTotalSold())
                .Returns(total);

            //act
            var result = FinancialController.GetTotalSold();

            //assert
            var NotFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            var total = Assert.IsType<List<Financial>>(NotFoundResult);
            Assert.Empty(ticketItems);

        }
    }
}