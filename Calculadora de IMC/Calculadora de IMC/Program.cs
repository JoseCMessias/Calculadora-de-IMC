using CalculadoraDeIMC.Models;

namespace CalculadoraDeIMC 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Calculadora calculadora = new Calculadora();   
            calculadora.Mensagem();
        }
    }
}

