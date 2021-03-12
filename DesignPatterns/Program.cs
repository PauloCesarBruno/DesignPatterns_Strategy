using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // [[strategy]]
            //========================================================


            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            // Intanciar a classe Orcamento e ecolocar o valor do orcamento como parâmetro
            Orcamento orcamento = new Orcamento(500.0);

            // Intanciar a classe CalculadorDe Impostos e ecolocar o valor do orcamento como parâmetro
            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);

            // Se houver no futro outro imposto é só implementar a Classe e add. Ex:
            // calculador.RalizaCalculo(orcamento, xpto) só implementar a classe xpto...

            Console.ReadKey();
        }
    }
}
