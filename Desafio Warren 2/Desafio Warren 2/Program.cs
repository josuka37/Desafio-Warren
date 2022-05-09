using System;

namespace Desafio_Warren_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, contador = 0; int[] tempoChegada = new int[5] { -2, -1, 0, 1, 2 };

            for (int i = 0; i < tempoChegada.Length; i++)
            {   
                ///conta quantos alunos chegaram atrasado, com tempo zero ou negativo.
                if (tempoChegada[i] <= 0)
                {
                    contador++;
                }
            }
            //verifica se x alunos chegaram a tempo.
            if (contador >= x)
            {
                Console.WriteLine("Aula Normal");
            }
            /// caso não, aula cancelada.
            else
            {
                Console.WriteLine("Aula Cancelada ");
            }
        }
    }
}
