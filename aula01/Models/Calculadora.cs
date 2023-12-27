using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula01.Models
{
    public class Calculadora
    {
        public void Somar(int X, int Y)
        {
            Console.WriteLine($"{X} + {Y} = {X + Y}");
        }
        public void Subtrair(int X, int Y)
        {
            Console.WriteLine($"{X} - {Y} = {X - Y}");
        }
        public void Multiplicar(int X, int Y)
        {
            Console.WriteLine($"{X} x {Y} = {X * Y}");
        }
        public void Dividir(int X, int Y)
        {
            Console.WriteLine($"{X} / {Y} = {X / Y}");
        }
        public void Potencia(int X, int Y)
        {
            double potencia = Math.Pow(X,Y);
            Console.WriteLine($"{X}^{Y} = {potencia}");
        }
    }
}