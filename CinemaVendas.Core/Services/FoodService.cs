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
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _fooRepo;

        public FoodService(IFoodRepository fooRepo)
        {
            _fooRepo = fooRepo;
        }

        public List<FoodItem> GetAllSold()

        {
            return _fooRepo.GetAllSold();
        }

        
    }
}
