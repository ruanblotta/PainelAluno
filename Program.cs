using System;

namespace PortalAluno
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao;

            Console.WriteLine("Bem vindo ao Portal do Aluno. Escolha uma das opções: ");
            Console.WriteLine("1. Adicionar Aluno(a). ");
            Console.WriteLine("2. Buscar Aluno(a). ");
            Console.WriteLine("3. Exibir Aluno(a)");
            Console.WriteLine("0. Sair do programa. ");

            do
            { 
                Console.WriteLine("Digite uma opção");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("1. Adicionar Aluno ");
                        break;
                    case "2":
                        Console.WriteLine("2. Buscar Aluno ");
                        break;
                    case "3":
                        Console.WriteLine("3. Exibir Alunos ");
                        break;
                    case "0":
                        Console.WriteLine("0. Sair do Programa.");
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida.");
                        break;
                } 
            } while (opcao != "0");
       } 
    }

}