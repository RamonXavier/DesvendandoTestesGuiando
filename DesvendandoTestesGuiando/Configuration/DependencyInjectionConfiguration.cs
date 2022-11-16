using DesvendandoTestes.Domain.Interfaces;
using DesvendandoTestes.Service.Interfaces;
using DesvendandoTestes.Service.Service;

namespace DesvendandoTestes.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddRepositoryDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IWeatherForecastRepository), typeof(IWeatherForecastRepository));
        }

        public static void AddServiceDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped(typeof(IWeatherForecastService), typeof(WeatherForecastService));
        }
    }
}
