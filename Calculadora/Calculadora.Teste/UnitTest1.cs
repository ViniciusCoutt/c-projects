using System;
using Xunit;

namespace Calculadora.Teste
{
    public class UnitTest1
    {
        [Fact]
        public void TesteSomar()
        {

            //Arrange - � aqui que voc� normalmente prepara tudo para o teste, em outras palavras, prepara a cena para testar(criar os objetos e configur� - los conforme necess�rio)
            double num1 = 4;
            double num2 = 3;
            double valorEsperado = 7;

            //Act - � onde o m�todo que estamos testando ser� executado;
            Calculadora calculadora = new Calculadora();
            double soma = calculadora.Somar(num1, num2);

            //Assert - Esta � a parte final do teste em que comparamos o que esperamos que aconte�a com o resultado real da execu��o do m�todo de teste;
            Assert.Equal(valorEsperado, soma);

        }

        [Fact]
        public void TesteSubtrair()
        {

            //Arrange
            double num1 = 5;
            double num2 = 1;
            double valorEsperado = 4;

            //Act 
            Calculadora calculadora = new Calculadora();
            double subtracao = calculadora.Subtrair(num1, num2);

            //Assert 
            Assert.Equal(valorEsperado, subtracao);

        }

        [Fact]
        public void TesteMultiplicar()
        {

            //Arrange
            double num1 = 3;
            double num2 = 3;
            double valorEsperado = 9;

            //Act 
            Calculadora calculadora = new Calculadora();
            double multiplicacao = calculadora.Multiplicar(num1, num2);

            //Assert 
            Assert.Equal(valorEsperado, multiplicacao);

        }

        [Fact]
        public void TesteDividir()
        {

            //Arrange
            double num1 = 4;
            double num2 = 2;
            double valorEsperado = 2;

            //Act 
            Calculadora calculadora = new Calculadora();
            double divisao = calculadora.Dividir(num1, num2);

            //Assert 
            Assert.Equal(valorEsperado, divisao);

        }
    }
}
