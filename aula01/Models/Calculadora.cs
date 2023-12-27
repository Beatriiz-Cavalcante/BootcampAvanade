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
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O seno de {angulo}°= {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O coseno de {angulo}°= {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI/180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O tangente de {angulo}°= {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}