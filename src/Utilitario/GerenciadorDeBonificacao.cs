namespace bytebank_adm.Utilitario;

public class GerenciadorDeBonificacao
{
    public double TotalBonificacao { get; set; }

    public void RegistrarBonificaco(Funcionario.Funcionario funcionario)
    {
        this.TotalBonificacao += funcionario.GetBonificacao();
    }

    public double GetBonificacao()
    {
        return this.TotalBonificacao;
    }
}