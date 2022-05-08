using System;

namespace Desafio_Warren_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int invertido = 0, numero = 0, soma = 0;

             /// Verifica todos os números a partir de 10 até 1 milhão
             for (int i = 10; i < 1000000; i++)
             {
                ///Desconsidera os números que terminam com zero.
                if (i%10 != 0)
                {
                    ///Faz a inversão do número
                     numero = i;
                     while (numero > 0)
                     {
                         invertido = invertido * 10 + numero % 10;
                         numero /= 10;
                     }
                        ///faz a soma do número com o invertido 
                        soma = i + invertido;

                        ///Verifica se a soma do número com o invertido resulta em número ímpar abaixo de 1 milhão, se sim, imprime resultado.
                     if ((soma)%2 != 0 && soma <1000000)
                     {
                        ///imprime resultado
                        Console.WriteLine(i +" + " + invertido +" = "+ soma);
                     }
                        invertido = 0;

                }
             }
            
            
        }
    }
    
}
