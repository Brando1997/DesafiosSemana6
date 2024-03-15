using System;

namespace Desafio_Promedio
{
    class Program
    {
        static void Main(string[] args)
      {
            Console.WriteLine("Ingrese las notas del alumno (escriba 'fin' para terminar):");

            int cantidadNotas = 0;
            double sumaNotas = 0;

            while (true)
            {
                Console.Write("Nota #{0}: ", cantidadNotas + 1);
                string input = Console.ReadLine();

                if (input.ToLower() == "fin")
                {
                    break;
                }

                if (double.TryParse(input, out double nota) && nota >= 1 && nota <= 10)
                {
                    sumaNotas += nota;
                    cantidadNotas++;
                }
                else
                {
                    Console.WriteLine("¡La nota ingresada no es válida! Debe ser un número entre 1 y 10.");
                }
            }

            if (cantidadNotas > 0)
            {
                double promedio = sumaNotas / cantidadNotas;
                Console.WriteLine("El promedio de las notas ingresadas es: {0}", promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron notas válidas.");
            }
        }
    }

}