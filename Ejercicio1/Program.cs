using System;

namespace Ejercicio1
{
    class adivinarNum
    {
       
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numeroRandom = rand.Next(0, 100);
            Console.WriteLine("Ingrese el numero: ");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());

            while (EvaluarPosicion(numeroUsuario, numeroRandom) == false)
            {
                Console.WriteLine("Ingrese el numero: ");
                numeroUsuario = Convert.ToInt32(Console.ReadLine());

            }
        }

        public static bool EvaluarPosicion(int n, int m)
        {
            if (n > m)
            {
                Console.WriteLine("el numero es mas grande");
            }
            if (n < m)
            {
                Console.WriteLine("el numero es mas chico");
            }
            if (n == m)
            {
                Console.WriteLine("encontraste el numero");
                return true;
            }
            return false;

        }
    }
}

