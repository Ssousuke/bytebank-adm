namespace bytebank_adm.Funcionarios;

public class Desenvolvedor : Funcionario
{
    public Desenvolvedor(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {
    }

    public override double GetBonificacao()
    {
        return Salario *= 0.12;
    }

    public override double AumentaSalario()
    {
        return Salario *= 0.12;
    }
}