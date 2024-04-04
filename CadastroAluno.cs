using System;
using System.Collections.Generic;
using System.Text;

namespace PortalAluno
{
    class CadastroIdAluno
    {
        private const int MaxAlunos = 20;
        private static Alunos[] alunosArray = new Alunos[MaxAlunos];
        private static int ContadorId = 0;

        public static void AdicionarIdAluno(string nome, string turma)
        {
            if (ContadorId < MaxAlunos)
            {
                ContadorId++;
                alunosArray[ContadorId -1] = new Alunos(ContadorId, nome, turma);
            }
            else 
            {
                Console.WriteLine("Não é possível adicionar mais Id de Aluno. Capacidade máxima atingida");
            }
        }

        public static void ListarAlunos()
        {
            for (int i = 0; i < ContadorId; i++)
            {
                Console.WriteLine(alunosArray[i]);
            }
        }
    }
    class Alunos
    {
        public int Id{get; private set;}
        public string Nome {get; set;}
        public string Turma {get; set;}

        // construtores
        public Alunos(int id, string nome, string turma)
        {
            Id = id;
            Nome = nome;
            Turma = turma;
        }

        public override string ToString()
        {
            return $"ID: {Id}\nAluno: {Nome}\nTurma: {Turma}";
        }
    }
}