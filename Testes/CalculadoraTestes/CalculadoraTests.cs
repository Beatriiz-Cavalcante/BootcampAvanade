using System.Data;
using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    //construtor
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        
        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);

    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;
        
        //Act
        bool resultado = _calc.EhPar(numero);
        
        //Assert
        Assert.True(resultado);
    } 

    //utilizando o Theory
    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero){
        //Arrange
        //Act
        bool resultado = _calc.EhPar(numero);
        //Assert
        Assert.True(resultado);
    }

    //refatorando (recebendo os números com array)
    [Theory]
    [InlineData(new int[] { 2, 4})]
    [InlineData(new int[] { 6, 8, 10})]
   
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro2(int[] numeros){
        //Arrange (já foi definido o cenário no inlinedata)
        //Act / Assert
        Assert.All(numeros, numAtual => Assert.True(_calc.EhPar(numAtual)));
    }
}