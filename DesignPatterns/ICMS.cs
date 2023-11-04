namespace DesignPatterns
{
    // Classe regras de negocio
    public class ICMS : Imposto  // Classe ICMS implementa Intaface Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor / 100*10; // ICMS 10% em cima do orçamento
        }
    }
}
