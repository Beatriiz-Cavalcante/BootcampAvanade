using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Curso
    {

        //propriedades
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }

            Console.WriteLine("\n\nLista usando concatenação\n\n");
            for(int count = 0; count<Alunos.Count; count++)
            {
                string texto = $"N° {count+1} -  {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}