namespace DesignPatterns
{
    public class ISS : Imposto  // Classe ISS implementa Intaface Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor /100 * 6; // ISS 06% em cima do orçamento
        }
    }
}
