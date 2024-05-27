using ProjetoFinal.Console.Models;

namespace ProjetoFinal.Tests;

public class CalculadoraTests
{
    Calculadora _calc = new Calculadora();
    public CalculadoraTests(){}

    [Theory]
    [InlineData (1,2,3)]
    [InlineData (4,5,9)]
    public void SomarNumeroseRetornarSucesso(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Somar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1,2,0)]
    [InlineData (4,5,0)]
    public void SomarNumeroseRetornarFalha(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Somar(val1, val2);

        //Assert
        Assert.NotEqual(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1,2,2)]
    [InlineData (4,5,20)]
    public void MultiplicarNumeroseRetornarSucesso(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Multiplicar(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1,2,0)]
    [InlineData (4,5,0)]
    public void MultiplicarNumeroseRetornarFalha(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Multiplicar(val1, val2);

        //Assert
        Assert.NotEqual(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (2,1,1)]
    [InlineData (5,4,1)]
    public void SubtrairNumeroseRetornarSucesso(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Subtrair(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (2,1,0)]
    [InlineData (5,4,0)]
    public void SubtrairNumeroseRetornarFalha(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Subtrair(val1, val2);

        //Assert
        Assert.NotEqual(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (2,1,2)]
    [InlineData (12,4,3)]
    public void DividirNumeroseRetornarSucesso(int val1, int val2, int resultado)
    {
        //Arrange

        //Act
        int resultadoCalc = _calc.Dividir(val1, val2);

        //Assert
        Assert.Equal(resultado, resultadoCalc);
        
    }

    [Fact]
    public void DividirPorZeroeRetornarException()
    {
        //Arrange
        //Act
        //Assert
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(2, 0)
        );
    }

    [Theory]
    [InlineData (2,1,0)]
    [InlineData (20,5,0)]
    public void DividirNumeroseRetornarFalha(int val1, int val2, int resultado)
    {
        //Arrange
        //Act
        int resultadoCalc = _calc.Dividir(val1, val2);
        //Assert
        Assert.NotEqual(resultado, resultadoCalc);
    }

    [Fact]
    public void TestarHistorico()
    {
        //Arrange
        _calc.Somar(1, 2);
        _calc.Somar(1, 10);
        _calc.Somar(1, 20);
        _calc.Somar(1, 22);
        _calc.Somar(1, 32);
        //Act
        var lista = _calc.Historico();
        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
