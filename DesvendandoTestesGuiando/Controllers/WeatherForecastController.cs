using Microsoft.AspNetCore.Mvc;

namespace DesvendandoTestesGuiando.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Ho444t", "Sweltering", "Scorching"
        };

        public WeatherForecastController()
        {
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public WeatherForecast GetFreezing()
        {
            var retorno = new WeatherForecast
            {
                Date = null,
                TemperatureC = 35,
                Summary = "Freezing"
            };

            if (retorno.Summary.Length < 4)
                return null;

            return retorno;
        }
    }
}