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
    public class FinancialsService : IFinancialsService
    {
        private readonly ITicketRepository _ticketRepo;
        private readonly IFoodRepository _foodRepo;

        public FinancialsService(ITicketRepository ticketRepo,
                                 IFoodRepository foodRepo)
        {
            _ticketRepo = ticketRepo;
            _foodRepo = foodRepo;
        }

        public decimal GetTotalSold()
        {
            var foodSold = _foodRepo.GetAllSold().Sum(x => x.Profit);
            var ticketsSold = _ticketRepo.GetAllSold().Sum(x => x.Profit);

            return foodSold + ticketsSold;
        }

        public FinancialStats GetStats()
        {
            FinancialStats stats = new FinancialStats();
            var foodSold = _foodRepo.GetAllSold();
            var ticketsSold = _ticketRepo.GetAllSold();

            //Calculate Average Stats
            stats.AverageTicketProfit = ticketsSold.Sum(x => x.Profit) / ticketsSold.Sum(x => x.Quantity);
            stats.AverageFoodItemProfit = foodSold.Sum(x => x.Profit) / foodSold.Sum(x => x.Quantity);

            return stats;
        }

        public object GetAllSold()
        {
            throw new NotImplementedException();
        }
    }
}
