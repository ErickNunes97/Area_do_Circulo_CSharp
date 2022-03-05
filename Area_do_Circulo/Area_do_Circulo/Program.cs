using System;

namespace Area_do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ================================================");
            Console.WriteLine("|                 Área do Círculo                |");
            Console.WriteLine(" ================================================\n\n");


            double pi = 3.1415;
            Console.WriteLine("\nDigite o raio do círculo: ");
            double r = double.Parse(Console.ReadLine());
            double a = pi * (r * r);
            Console.WriteLine("\nA área do seu círculo é: " + a);

        }
    }
}
