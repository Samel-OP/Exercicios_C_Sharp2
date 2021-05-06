using System;

namespace ConsoleUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
             bool valido = false;

            do
            {
                Console.WriteLine("Escreva seu nome de usuário: ");
                string nome = Console.ReadLine().ToLower();

                Console.WriteLine("Escreva sua senha: ");
                string senha = Console.ReadLine().ToLower();

                if (nome != senha)
                {
                    Console.WriteLine("Cadastro feito com sucesso!");
                    valido = true;
                }
                else
                {
                    Console.WriteLine("Erro, a senha não pode ser igual ao nome de usuário (informe novamente o nome de usuário e a senha!)"); 
                }
            } while (valido == false);
        }
    }
}
