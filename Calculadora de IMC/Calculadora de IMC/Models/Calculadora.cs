using System.Globalization;

namespace CalculadoraDeIMC.Models
{
    public class Calculadora
    {
        private double Peso { get;  set; }
        private double Altura { get;  set; }

        private double CalculoIMC()
        {
            return Peso / Math.Pow(Altura, 2);
        }

        private string Situacao(double imc)
        {
            // Váriavel
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                retorno = "Peso normal";
            }
            else if (imc < 30)
            {
                retorno = "A cima do peso";
            }
            else if (imc < 35)
            {
                retorno = "Obesidade I";
            }
            else if (imc < 40)
            {
                retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }
            return retorno;
        }

        public void Mensagem()
        {
            Console.WriteLine("          ____________IMC____________");
            Console.WriteLine();
            Console.Write("          - Digite a sua altura: ");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("          - Digite o seu peso: ");
            Peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // Obter o cálculo
            double obterCalculo = CalculoIMC();
            //Obter Situação
            string obterSituação = Situacao(obterCalculo);

            Console.WriteLine($"          - Seu IMC é de {obterCalculo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"          - Sua situação é de {obterSituação}");
        }
    }
}
