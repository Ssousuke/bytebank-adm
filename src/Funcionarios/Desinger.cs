namespace bytebank_adm.Funcionarios;

public class Desinger : Funcionario
{
    public Desinger(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {
    }

    public override double AumentaSalario()
    {
        return Salario *= 1.11;
    }

    public override double GetBonificacao()
    {
        return Salario + 0.17;
    }
}