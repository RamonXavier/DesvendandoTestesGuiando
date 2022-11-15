using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesvendandoTestes.Domain.Interfaces
{
    public interface IWeatherForecastRepository
    {
        public void Adicionar(WeatherForecast novoWeatherForecast);
        
        public IEnumerable<WeatherForecast> BuscarTodos();
    }
}
