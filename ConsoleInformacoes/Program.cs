using System;

namespace ConsoleInformacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validoZero = false;

            bool validoOne = false;

            bool validoTwo = false;

            bool validoThree = false;

            string nome = "";

            int idade = 0;

            float salario = 0;

            string estadoCivil = "";

            while (validoZero == false)
            {
                while (validoOne == false)
                {
                    Console.Write("Escreva seu Nome: ");
                    nome = Console.ReadLine();

                    if (nome != "")
                    {
                        validoOne = true;
                    }
                    else
                    {
                        Console.WriteLine("Nome inválido! \n");
                    }
                }

                while (validoTwo == false)
                {
                    Console.Write("Escreva sua Idade: ");
                    idade = int.Parse(Console.ReadLine());

                    if (idade >= 0 && idade <= 150)
                    {
                        validoTwo = true;
                    }
                    else
                    {
                        Console.WriteLine("Idade inválida! \n");
                    }
                }
                while (validoThree == false)
                {
                    Console.Write("Escreva seu Salário: ");
                    salario = float.Parse(Console.ReadLine());

                    if (salario > 0)
                    {
                        validoThree = true;
                    }
                    else
                    {
                        Console.WriteLine("Salário inválido! \n");
                    }
                }
                while (validoZero == false)
                {
                    Console.Write("Estado Civil (Sendo 's'/'c'/'v'/'d' - Solteiro(a), Casado(a), Viúvo(a) e Divorciado(a), respectivamente: \n");
                    estadoCivil = Console.ReadLine().ToLower();

                    if (estadoCivil == "s")
                    {
                        estadoCivil = "Solteiro(a)";
                        validoZero = true;
                    }
                    else if (estadoCivil == "c")
                    {
                        estadoCivil = "Casado(a)";
                        validoZero = true;
                    }
                    else if (estadoCivil == "v")
                    {
                        estadoCivil = "Viúvo(a)";
                        validoZero = true;
                    }
                    else if (estadoCivil == "d")
                    {
                        estadoCivil = "Divorciado(a)";
                        validoZero = true;
                    }
                    else
                    {
                        Console.WriteLine("Estado civil inválido! \n");
                        validoZero = false;
                    }
                }
                if (validoZero == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Suas informações: \n");
                    Console.WriteLine("Seu nome é: " + nome);
                    Console.WriteLine("Sua idade é: " + idade);
                    Console.WriteLine("Seu salário é: " + salario);
                    Console.WriteLine("Seu estado civil é: " + estadoCivil + "\n");

                    //ISSO ABAIXO É UM SISTEMA A MAIS QUE ESTAVA QUERENDO FAZER MAS NÃO CONSEGUI TERMINAR, MAS O PRINCIPAL ESTÁ FUNCIONANDO CORRETAMENTE.

                    //Console.WriteLine("Suas informações estão corretas? ('s' se sim e 'n' se não)");
                    //string confirmacao = Console.ReadLine().ToLower();

                    //else if (confirmacao == "s")
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Green;
                    //    Console.WriteLine("Cadastro efetivado com sucesso!");
                    //    validoZero = true;
                    //}
                    //else
                    // {
                    //     Console.ForegroundColor = ConsoleColor.DarkRed;
                    //     Console.WriteLine("Insira suas informações novamente!");
                    //     validoZero = false;
                    // }
                }
            }
        }
    }
}
