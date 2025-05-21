// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Volume
{
    private double Radio;
    private double Hal;

    // Constructor para inicializar Radio y Altura
    public Volume(double radio, double hal)
    {
        Radio = radio;
        Hal = hal;
    }

    // Método para calcular el volumen del cilindro
    public double CalcularVolumen()
    {
        return Math.PI * Math.Pow(Radio, 2) * Hal;
    }

    static void Main(string[] args)
    {
        // Ejemplo de uso
        Console.Write("Ingrese el radio del cilindro: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del cilindro: ");
        double hal = Convert.ToDouble(Console.ReadLine());

        Volume volumen = new Volume(radio, hal);
        Console.WriteLine($"El volumen del cilindro es: {volumen.CalcularVolumen():F2}");
    }
}
