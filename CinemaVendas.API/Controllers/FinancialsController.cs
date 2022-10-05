using CinemaVendas.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaVendas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialsController : ControllerBase
    {
        private readonly IFinancialsService _financialsService;

        public FinancialsController(IFinancialsService financialsService)
        {
            _financialsService = financialsService;
        }

        [HttpGet("TotalSold")]
        public IActionResult GetTotalSold()
        {
            return Ok(_financialsService.GetAllSold());
        }

        [HttpGet("SoldStats")]
        public IActionResult GetStats()
        {
            return Ok(_financialsService.GetStats());
        }
    }
}
