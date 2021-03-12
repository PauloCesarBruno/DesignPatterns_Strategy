namespace DesignPatterns
{
    // RESPONSABILIDADE: Apresentar um unico orçamento
    public class Orcamento   
    {
        public double Valor { get; private set; }

        //Construtor
        public Orcamento(double valor)
        {
            this.Valor = valor;
        }
    }
}
