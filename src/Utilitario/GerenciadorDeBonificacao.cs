using bytebank.Funcionario;

public class GerenciadorDeBonificacao
{
    public double TotalBonificacao { get; set; }

    public void RegistrarBonificaco(Funcionario funcionario)
    {
        this.TotalBonificacao += funcionario.GetBonificacao();
    }

    public double GetBonificacao()
    {
        return this.TotalBonificacao;
    }
}