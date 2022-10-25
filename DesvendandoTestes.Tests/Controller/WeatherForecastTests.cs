using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesvendandoTestesGuiando;
using DesvendandoTestesGuiando.Controllers;
using FluentAssertions;

namespace DesvendandoTestes.Tests.Controller
{
    public class WeatherForecastTests
    {

        private readonly WeatherForecastController _controller;

        public WeatherForecastTests()
        {
            _controller = new WeatherForecastController();
        }

        [Fact]
        public void GetFreezing_naoPossuiEntrada_RetornaObjetoTipoWeatherForecast_comSucessoMasDiferente() //NOME DO METODO QUE VOU TESTAR _ AS ENTRADAS NECESSARIAS _ SAIDA ESPERADA
        {
            //DEVE FALHAR

            //ARRANGE - MONTA A ESTRUTURA PARA TESTAR

            var resultadoEsperado = new WeatherForecast
            {
                Date = null,
                TemperatureC = 35,
                Summary = "FreezinR"
            };

            //ACT - METODO QUE QUERO TESTAR
            var resultado = _controller.GetFreezing();

            //ASSERT - O QUE ESPERAMOS DE RETORNO
            resultado.Should().NotBeEquivalentTo(resultadoEsperado); // VERIFICA SE A SAIDO É IGUAL AO QUE EU ESPERO
        }

        [Fact]
        public void GetFreezing_naoPossuiEntrada_RetornaObjetoTipoWeatherForecast_comSucessoIgual() //NOME DO METODO QUE VOU TESTAR _ AS ENTRADAS NECESSARIAS _ SAIDA ESPERADA
        {
            // DEVE PASSAR

            //ARRANGE - MONTA A ESTRUTURA PARA TESTAR

            var resultadoEsperado = new WeatherForecast
            {
                Date = null,
                TemperatureC = 35,
                Summary = "Freezing"
            };

            //ACT - METODO QUE QUERO TESTAR
            var resultado = _controller.GetFreezing();

            //ASSERT - O QUE ESPERAMOS DE RETORNO
            resultado.Should().BeEquivalentTo(resultadoEsperado); // VERIFICA SE A SAIDO É IGUAL AO QUE EU ESPERO
        }
    }
}
