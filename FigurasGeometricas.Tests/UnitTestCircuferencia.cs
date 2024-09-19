namespace FigurasGeometricas.Tests;

[TestClass]
public class CircunferenciaTests
{
    [TestMethod]
    public void TestSuperficie_CircunferenciaConRadioPositivo()
    {
        double radio = 3;
        Circunferencia circunferencia = new Circunferencia(radio);
        double resultado = circunferencia.CalcularSuperficie();
        Assert.AreEqual(Math.PI * 9, resultado, 0.0001);
    }

    [TestMethod]
    public void TestPerimetro_CircunferenciaConRadioPositivo()
    {
        double radio = 3;
        Circunferencia circunferencia = new Circunferencia(radio);
        double resultado = circunferencia.CalcularPerimetro();
        Assert.AreEqual(2 * Math.PI * 3, resultado, 0.0001);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestRadioInvalido_CircunferenciaDebeLanzarExcepcion()
    {
        double radio = -3;
        Circunferencia circunferencia = new Circunferencia(radio);
    }
}
