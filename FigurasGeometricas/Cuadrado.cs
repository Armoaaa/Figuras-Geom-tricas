namespace FigurasGeometricas;

public class Cuadrado
{
    public double Lado { get; set; }

    public Cuadrado(double lado)
    {
        if (lado <= 0)
        {
            throw new ArgumentException("El valor del lado debe ser positivo.");
        }
        Lado = lado;
    }

    public double CalcularSuperficie()
    {
        return Lado * Lado;
    }

    public double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}
