using Microsoft.AspNetCore.Mvc;

namespace WEB_APIS_10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 3).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
     [HttpGet("Test")]
     public object GetTest()
     {
         return new { DateNow = DateTime.Now, UTCDateNow = DateTime.UtcNow, NumLists = Enumerable.Range(1, 100), DocNums= Enumerable.Sequence<int>(100,150,1).Select(num=> $"A-{num}") };
     }
    }
}
