using System;

namespace Desafio_Warren_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int invertido = 0, numero = 0, soma = 0;


             for (int i = 10; i < 1000000; i++)
             {
                if (i%10 != 0)
                {
                     numero = i;
                     while (numero > 0)
                     {
                         invertido = invertido * 10 + numero % 10;
                         numero /= 10;
                     }
                        soma = i + invertido;
                     if ((soma)%2 != 0 && soma <1000000)
                     {
                        Console.WriteLine(i +" + " + invertido +" = "+ soma);
                     }
                        invertido = 0;

                }
             }
            
            
        }
    }
    
}
