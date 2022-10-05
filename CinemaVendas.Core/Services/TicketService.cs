using CinemaVendas.Core.Repository.Interface;
using CinemaVendas.Core.Services.Interfaces;
using RepositoryServicePatternDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepo;

        public TicketService(ITicketRepository ticketRepo)
        {
            _ticketRepo = ticketRepo;
        }

        public List<Ticket> GetAllSold() => _ticketRepo.GetAllSold();
    }
}