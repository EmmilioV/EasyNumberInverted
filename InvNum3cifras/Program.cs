using System;

namespace InvNum3cifras
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            do
            {

                Console.WriteLine("DIgite el número de tres cifras que desea invertir");
                numero = int.Parse(Console.ReadLine());

            } while (numero < 99 || numero > 999);

            int numeroInv = invertirNumero(numero);
            Console.WriteLine($"el numero invertido es: {numeroInv}");

        }

        public static int invertirNumero(int numero)
        {
            int residuo1 = numero % 10;
            int resultado1 = numero / 10;
            int residuo2 = resultado1 % 10;
            int resultado2 = resultado1 / 10;

            int numeroinvertido = residuo1*100 + residuo2*10 + resultado2;

            return numeroinvertido;
        }
    }
}
