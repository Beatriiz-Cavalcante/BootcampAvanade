using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
         public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        //Não precisou implementar o método Dividir pois ele já tem corpo na definição da interface

    }
}