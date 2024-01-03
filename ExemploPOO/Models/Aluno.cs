using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {    
         public Aluno()
        {
            
        }
        //construtor com herança
        public Aluno(string nome) : base(nome) 
        {

        }
        public int Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu sou estudante nota {Nota}");
        }
    }
}