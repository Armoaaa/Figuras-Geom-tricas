namespace FigurasGeometricas.Tests;

[TestClass]
public class CuadradoTests
{
    [TestMethod]
    public void TestSuperficie_CuadradoConLadoPositivo()
    {
        double lado = 5;
        Cuadrado cuadrado = new Cuadrado(lado);
        double resultado = cuadrado.CalcularSuperficie();
        Assert.AreEqual(25, resultado);
    }

    [TestMethod]
    public void TestPerimetro_CuadradoConLadoPositivo()
    {
        double lado = 5;
        Cuadrado cuadrado = new Cuadrado(lado);
        double resultado = cuadrado.CalcularPerimetro();
        Assert.AreEqual(20, resultado);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestLadoInvalido_CuadradoDebeLanzarExcepcion()
    {
        double lado = -5;
        Cuadrado cuadrado = new Cuadrado(lado);
    }
}
