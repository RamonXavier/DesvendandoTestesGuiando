using DesvendandoTestes.Domain.Interfaces;
using DesvendandoTestes.Service.Dto.WeatherForecast;
using DesvendandoTestes.Service.Interfaces;

namespace DesvendandoTestes.Service.Service
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }
        
        public void Adicionar(AdicionarWeatherForecastDto adicionarWeatherForecastDto)
        {
            var weatherForecast = new WeatherForecast(
                adicionarWeatherForecastDto.Date,
                adicionarWeatherForecastDto.TemperatureC,
                adicionarWeatherForecastDto.Summary);

            _weatherForecastRepository.Adicionar(weatherForecast);
        }

        public IEnumerable<WeatherForecast> BuscarTodos()
        {
            var weatherForecasts = _weatherForecastRepository.BuscarTodos();

            return weatherForecasts;
        }

        public WeatherForecast BuscarTemperaturaMaisBaixa()
        {
            var listaOrdenada = _weatherForecastRepository.BuscarTodos().OrderBy(x => x.TemperatureC);

            return listaOrdenada.First();
        }

        public WeatherForecast BuscarTemperaturaMaisAlta()
        {
            var listaOrdenada = _weatherForecastRepository.BuscarTodos().OrderByDescending(x => x.TemperatureC);

            return listaOrdenada.First();
        }
    }
}
