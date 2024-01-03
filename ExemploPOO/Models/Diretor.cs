using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        //o método não pode ser alterado se o fornecido pela classe pai for selado
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu sou Diretor e ganho {Salario} por mês");
        }
    }
}