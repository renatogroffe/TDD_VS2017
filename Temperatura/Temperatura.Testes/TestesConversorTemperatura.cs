using Xunit;
using FluentAssertions;

namespace Temperatura.Testes
{
    public class TestesConversorTemperatura
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(212, 100)]
        public void TesteConversaoTemperatura1(
            double tempFahrenheit, double tempCelsius)
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(tempFahrenheit);
            valorCalculado.Should().Be(tempCelsius,
                "Valor calculado não coincide com a temperatura Celsius esperada");
        }
    }
}