using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK, Type=typeof(IEnumerable<WeatherForecast>))]
        [SwaggerResponse((int)HttpStatusCode.NotFound, Description = "Forecast not found")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.Created, Description = "The tracker was successfully created.")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Internal Error")]
        public IActionResult CreateTracker([FromBody] int tracker)
        {
            throw new NotImplementedException("");
        }
    }
}
