using Xunit;
using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        // Testa o método Somar com três conjuntos de valores diferentes
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, -2)]
        public void Somar_DeveRetornarCorreto(double a, double b, double esperado)
        {
            double resultado = Program.Somar(a, b);
            Assert.Equal(esperado, resultado);
        }

        // Testa o método Subtrair com três conjuntos de valores diferentes
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(0, 5, -5)]
        [InlineData(-5, -3, -2)]
        public void Subtrair_DeveRetornarCorreto(double a, double b, double esperado)
        {
            double resultado = Program.Subtrair(a, b);
            Assert.Equal(esperado, resultado);
        }

        // Testa o método Multiplicar com três conjuntos de valores diferentes
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(0, 5, 0)]
        [InlineData(-2, 3, -6)]
        public void Multiplicar_DeveRetornarCorreto(double a, double b, double esperado)
        {
            double resultado = Program.Multiplicar(a, b);
            Assert.Equal(esperado, resultado);
        }

        // Testa o método Dividir com três conjuntos de valores diferentes
        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(5, 2, 2.5)]
        [InlineData(-6, 3, -2)]
        public void Dividir_DeveRetornarCorreto(double a, double b, double esperado)
        {
            double resultado = Program.Dividir(a, b);
            Assert.Equal(esperado, resultado);
        }

        // Testa se o método Dividir lança a exceção correta ao tentar dividir por zero
        [Fact]
        public void Dividir_DeveLancarExcecao_DivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => Program.Dividir(6, 0));
        }
    }
}
