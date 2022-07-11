using bytebank_adm.Funcionarios;

namespace bytebank_adm.Utilitario;

public class GerenciadorDeBonificacao
{
    private double _totalBonificacao;

    public void RegistrarBonificaco(Funcionario funcionario)
    {
        this._totalBonificacao += funcionario.GetBonificacao();
    }

    public double GetBonificacao()
    {
        return this._totalBonificacao;
    }
}