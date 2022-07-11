using bytebank_adm.src.Funcionarios;

namespace bytebank_adm.Funcionarios;

public class GerenteDeContas : FuncionarioAutenticavel
{
    public string Senha { get; set; }

    public GerenteDeContas(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario, senha)
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