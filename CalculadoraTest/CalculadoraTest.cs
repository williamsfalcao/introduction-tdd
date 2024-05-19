using Calculadora.Model;

namespace CalculadoraTest;

public class UnitTest1
{

    [Theory]
    [InlineData(2,3,5)]
    [InlineData(4,5,9)]
    public void SomarTest(int val1, int val2, int resExperado)
    {

        Claculadora calc = new Claculadora();
        var res = calc.Somar(val1, val2);

        Assert.Equal(resExperado, res);
    }

    [Theory]
    [InlineData(9,3,3)]
    [InlineData(12,4,3)]
    public void DividirTest(int val1, int val2, int resExperado)
    {
         Claculadora calc = new Claculadora();
        var res = calc.Dividir(val1, val2);

        Assert.Equal(resExperado, res);
    }

    [Fact]
    public void DivisaoPorZero()
    {
        Claculadora calc = new Claculadora();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Theory]
    [InlineData(5,3,2)]
    [InlineData(9,5,4)]
    public void SubtrairTest(int val1, int val2, int resExperado)
    {
         Claculadora calc = new Claculadora();
        var res = calc.Subtrair(val1, val2);

        Assert.Equal(resExperado, res);
    }

    [Theory]
    [InlineData(2,3,6)]
    [InlineData(4,5,20)]
    public void MultiplicarTest(int val1, int val2, int resExperado)
    {
        Claculadora calc = new Claculadora();
        var res = calc.Multiplicar(val1, val2);

        Assert.Equal(resExperado, res);
    }

    
    [Fact]
    public void HistoricoTest()
    {
         Claculadora calc = new Claculadora();
         calc.Multiplicar(1, 2);
         calc.Multiplicar(2, 3);
         calc.Multiplicar(3, 4);
         calc.Multiplicar(4, 5);
        Assert.Equal(3, calc.Historico().Count);
    }
}