using DesvendandoTestes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesvendandoTestes.Infrastructure.Repository
{
    internal class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly List<WeatherForecast> _forecasts;

        public WeatherForecastRepository()
        {
            _forecasts = new List<WeatherForecast>()
            {
                new WeatherForecast(DateTime.Now, 10, "temperatura baixa"),
                new WeatherForecast(DateTime.Now, 20, "temperatura média"),
                new WeatherForecast(DateTime.Now, 30, "temperatura alta")
            };
        }
        
        public void Adicionar(WeatherForecast novoWeatherForecast)
        {
            _forecasts.Add(novoWeatherForecast);
        }

        public IEnumerable<WeatherForecast> BuscarTodos()
        {
            return _forecasts;
        }
    }
}
