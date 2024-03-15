using System;

namespace Desafio_1
{
    class Rectangulo
{
    public double Alto { get; }
    public double Largo { get; }

    public double SuperficieFrontal
    {
        get { return Alto * Largo; }
    }

    public Rectangulo(double alto, double largo)
    {
        Alto = alto;
        Largo = largo;
    }
}   

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo(5, 10);

        Console.WriteLine("Superficie frontal del rectángulo: {0}", rectangulo.SuperficieFrontal);
    }
}
}