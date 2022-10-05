using CinemaVendas.Core.Services.Interfaces;
using System;

namespace CinemaVendas.API.Test
{
    internal class FinancialController
    {
        private IFinancialsService @object;

        public FinancialController(IFinancialsService @object)
        {
            this.@object = @object;
        }

        internal static object GetTotalSold()
        {
            throw new NotImplementedException();
        }
    }
}