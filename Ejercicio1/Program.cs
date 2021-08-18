using System;

namespace Ejercicio1
{
    class adivinarNum
    {
       
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numeroRandom = rand.Next(0, 100);
            int numeroUsuario = -1;

            while (EvaluarPosicion(numeroRandom, numeroUsuario) == false)
            {
                try
                {
                    Console.WriteLine("Elija un numero: ");
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error! El valor ingresado es invalido");
                    numeroUsuario = -1;
                }
            }
        }

        public static bool EvaluarPosicion(int n, int m)
        {
            if(m == -1)
            {
                return false;
            }
            else
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
}

