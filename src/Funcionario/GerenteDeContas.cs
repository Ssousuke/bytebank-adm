namespace bytebank_adm.Funcionario;

public class GerenteDeContas : Funcionario
{
    public GerenteDeContas(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {
    }

    public override double AumentaSalario()
    {
        return Salario *= 1.14;
    }

    public override double GetBonificacao()
    {
        return Salario + 0.15;
    }
}