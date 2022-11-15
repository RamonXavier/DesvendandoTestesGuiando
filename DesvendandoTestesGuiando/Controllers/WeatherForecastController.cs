using DesvendandoTestes.Service.Dto.WeatherForecast;
using DesvendandoTestes.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesvendandoTestes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodos()
        {
            try
            {
                var weatherForecasts = _weatherForecastService.BuscarTodos();
                return Ok(weatherForecasts);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTemperaturaMaisAlta()
        {
            try
            {
                var weatherForecast = _weatherForecastService.BuscarTemperaturaMaisAlta();
                return Ok(weatherForecast);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTemperaturaMaisBaixa()
        {
            try
            {
                var weatherForecast = _weatherForecastService.BuscarTemperaturaMaisBaixa();
                return Ok(weatherForecast);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(AdicionarWeatherForecastDto adicionarWeatherForecastDto)
        {
            try
            {
                _weatherForecastService.Adicionar(adicionarWeatherForecastDto);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}