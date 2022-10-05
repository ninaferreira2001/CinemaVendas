using RepositoryServicePatternDemo.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaVendas.Core.Repository.Interface
{
    public interface ITicketRepository
    {
        List<Ticket> GetAllSold();
    }
}
