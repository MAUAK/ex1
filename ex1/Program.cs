using System;
using System.Globalization;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*----------------------------------

            Kauam Silva Batista - RA: 210501

            ----------------------------------*/

            //Declarando variaveis da classe triangulo
            triangulo x, y;

            //Instanciando variavel
            x = new triangulo();
            y = new triangulo();

            //Pedindo as medidas
            Console.WriteLine("Entre com as medidas do triângulo X:"); 
            //Gravando os lados para as variaveis do objeto da classe triangulo x
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando variaveis para armazenar a área do trinagulo x
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //Pedindo as medidas
            Console.WriteLine("\nEntre com as medidas do triângulo X:");
            //Gravando os lados para as variaveis do objeto da classe triangulo y
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando variaveis para armazenar a área do trinagulo y
            double p2 = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p2 * (p2 - y.A) * (p2 - y.B) * (p2 - y.C));

            //Escrevendo as áreas dos dois triangulos
            Console.WriteLine("\nA área se X = " + areaX.ToString("f4", CultureInfo.InvariantCulture) + " e a área do Y = " + areaY.ToString("f4", CultureInfo.InvariantCulture));

            //comparando se a área do X é maior que a do Y
            if (areaX > areaY)
            {
                //Imprimindo que a área de X é maior
                Console.WriteLine("\nA área do X é maior.");
            }
            else
            {
                //Imprimindo que a área de X é menor
                Console.WriteLine("\nA área do Y é maior.");
            }
        }
    }
}




