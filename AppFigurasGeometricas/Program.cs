class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese el lado del cuadrado:");
            string inputLado = Console.ReadLine();
            if (!double.TryParse(inputLado, out double lado) || lado <= 0)
            {
                Console.WriteLine("El valor ingresado es incorrecto.");
                return;
            }

            Cuadrado cuadrado = new Cuadrado(lado);
            Console.WriteLine($"Superficie del cuadrado: {cuadrado.CalcularSuperficie()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");

            Console.WriteLine("Ingrese el radio de la circunferencia:");
            string inputRadio = Console.ReadLine();
            if (!double.TryParse(inputRadio, out double radio) || radio <= 0)
            {
                Console.WriteLine("El valor ingresado es incorrecto.");
                return;
            }

            Circunferencia circunferencia = new Circunferencia(radio);
            Console.WriteLine($"Superficie de la circunferencia: {circunferencia.CalcularSuperficie()}");
            Console.WriteLine($"Perímetro de la circunferencia: {circunferencia.CalcularPerimetro()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
ru