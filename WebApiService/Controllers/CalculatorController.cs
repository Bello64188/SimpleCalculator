using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiService.Data;
using WebApiService.IRepository;
using WebApiService.Model;

namespace WebApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly AppDbContext _cxt;
        private readonly IGenericRepository<Log> _repository;

        public CalculatorController(AppDbContext context, IGenericRepository<Log> repository)
        {
            _cxt = context;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetLog()
        {
            var logs = _repository.GetLogs();
            return Ok(logs);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult LogCompute([FromBody] Log simple)
        {
            _cxt.Add(simple);
            _cxt.SaveChanges();
            return Ok();

        }
    }
}
