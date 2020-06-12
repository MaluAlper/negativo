using System;

namespace negativo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Leia um número inteiro e exiba a mensagem "Você digitou um número negativo."
            // caso o número seja menor que zero.

            string negativo;
            int numero;


            Console.WriteLine("Digite um numero");
            negativo=Console.ReadLine();
            numero = Int32.Parse(negativo);
            
            if (numero<0)
            {
                Console.WriteLine("Este numero é negativo!");
            }

            

    




        }
    }
}
