using System;

namespace ConsoleNotaValida
{
    class Program
    {
        static void Main(string[] args)
        {
            bool respostaCorreta = false;

            while (respostaCorreta == false)
            {
                Console.WriteLine("Escreva uma nota (entre 0 a 10): ");
                int resposta = int.Parse(Console.ReadLine());

                if (resposta >= 0 && resposta <= 10)
                {
                    Console.WriteLine("Nota enviada com sucesso!");
                    respostaCorreta = true;
                }
                else
                {
                    Console.WriteLine("Nota inválida!");
                    respostaCorreta = false;
                }
            }
        }
    }
}
