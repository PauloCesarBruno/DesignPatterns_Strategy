using System;

namespace DesignPatterns
{
    // RESPONSABILIDADE: Calcular um Imposto para o orcamento
    public class CalculadorDeImpostos  
    {
        // Independe de um Imposto concreto
        // Depende da abstração da Interface
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double impostos = imposto.Calcula(orcamento);
            Console.WriteLine ( "===============================================");
            Console.WriteLine(impostos);
        }
    }
}
