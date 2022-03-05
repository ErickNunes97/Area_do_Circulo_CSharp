using System;

namespace Area_do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDeseja calcular a área do círculo: ");

            string a = Console.ReadLine();
            Console.WriteLine("\n\n");


            while (a !="n")
            {
                

                Console.WriteLine(" ************************************************");
                Console.WriteLine(" *                 Área do Círculo              *");
                Console.WriteLine(" ************************************************\n\n");


                double pi = 3.1415;
                Console.WriteLine("\nDigite o raio do círculo: ");
                double r = double.Parse(Console.ReadLine());
                double area = pi * (r * r);
                Console.WriteLine("\nA área do seu círculo é: " + area);
                Console.WriteLine("=====================================================\n");

                Console.WriteLine("\nDeseja calcular novamente: ");
                string n = Console.ReadLine();

                if(n=="n")
                {
                    Console.WriteLine("\nFinalizado");
                    break;
                }

                else
                {
                    Console.WriteLine("\nContinua\n\n");
                    continue;
                }
            }
        }
    }
}
