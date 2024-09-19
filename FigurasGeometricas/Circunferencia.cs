namespace FigurasGeometricas.obj
public class Circunferencia
{
    public double Radio { get; set; }

    public Circunferencia(double radio)
    {
        if (radio <= 0)
        {
            throw new ArgumentException("El valor del radio debe ser positivo.");
        }
        Radio = radio;
    }

    public double CalcularSuperficie()
    {
        return Math.PI * Radio * Radio;
    }

    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}
