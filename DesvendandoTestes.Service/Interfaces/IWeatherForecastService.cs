using DesvendandoTestes.Service.Dto.WeatherForecast;

namespace DesvendandoTestes.Service.Interfaces
{
    public interface IWeatherForecastService
    {
        public void Adicionar(AdicionarWeatherForecastDto adicionarWeatherForecastDto);

        public IEnumerable<WeatherForecast> BuscarTodos();

        public WeatherForecast BuscarTemperaturaMaisBaixa();

        public WeatherForecast BuscarTemperaturaMaisAlta();
    }
}
