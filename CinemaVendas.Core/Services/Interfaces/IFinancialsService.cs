using RepositoryServicePatternDemo.Core.Models;

namespace CinemaVendas.Core.Services.Interfaces
{
    public interface IFinancialsService
    {
        decimal GetTotalSold();
        FinancialStats GetStats();
        object GetAllSold();
    }
}
