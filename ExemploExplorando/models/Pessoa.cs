using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.models
{
    public class Pessoa
    {
        //construtores
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        //propriedaades
        private string _nome;
        private int _idade;
        public string? Nome
         { 
            get 
            {
                return _nome.ToUpper();
            }
            //outra forma de sintaxe(body expressions): get =>  _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
         }
        public string? Sobrenome { get; set; }

        public string? NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade 
        { 
            get => _idade;
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        //métodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}