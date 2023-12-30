using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public override Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e eu sou professor e ganho {Salario} por mês");
        }
    }
}