using CinemaVendas.API.Controllers;
using CinemaVendas.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RepositoryServicePatternDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CinemaVendas.API.Test
{
    public class TicketControllerTest
    {

        Mock<ITicketService> mockService;
        TicketController ticketController;
       

        public TicketControllerTest()
        {
            mockService = new Mock<ITicketService>();
            ticketController = new TicketController(mockService.Object);
        }
        [Fact]
        public void GetTickets_WithData_ReturnOkResult()
        {
            //arrange
            mockService.Setup(service => service.GetAllSold())
                .Returns(new List<Ticket>()
                 {
                new Ticket() { ID = 256, MovieName = "Coringa"},
                new Ticket() { ID = 498, MovieName = "Princesa" }
            });

            //act
            var result = ticketController.GetTickets();
            //assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var ticketItems = Assert.IsType<List<Ticket>>(okResult.Value);
            Assert.Equal(2, ticketItems.Count);
        }

        [Fact]
        public void GetTickets_WithoutData_NotFoundResult()
        {
            //arrange
            mockService.Setup(service => service.GetAllSold())
                .Returns(new List<Ticket>()
            );

            //act
            var result = ticketController.GetTickets();
            //assert
            var notFoundResult = Assert.IsType<NotFoundObjectResult>(result);
            var ticketItems = Assert.IsType<List<Ticket>>(notFoundResult.Value);
            Assert.Empty(ticketItems);
        }
    }
}
