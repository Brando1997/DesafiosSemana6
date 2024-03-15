using System;

namespace Desafio_2
{
    class Caja
{
    public double Ancho { get; }
    public double Largo { get; }
    public double Alto { get; }

    public Caja(double ancho, double largo, double alto)
    {
        Ancho = ancho;
        Largo = largo;
        Alto = alto;
    }

    public double CalcularVolumen()
    {
        return Ancho * Largo * Alto;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el número de cajas:");
        int numCajas = int.Parse(Console.ReadLine());

        double totalVolumen = 0;

        for (int i = 0; i < numCajas; i++)
        {
            Console.WriteLine($"\nIngrese las dimensiones para la caja {i + 1}:");
            Console.Write("Ancho: ");
            double ancho = double.Parse(Console.ReadLine());
            Console.Write("Largo: ");
            double largo = double.Parse(Console.ReadLine());
            Console.Write("Alto: ");
            double alto = double.Parse(Console.ReadLine());

            Caja caja = new Caja(ancho, largo, alto);
            totalVolumen += caja.CalcularVolumen();
        }

        double volumenPromedio = totalVolumen / numCajas;

        Console.WriteLine($"\nEl total de volumen de las cajas es: {totalVolumen}");
        Console.WriteLine($"El volumen promedio de las cajas es: {volumenPromedio}");
    }
}
}