using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public class Autenticavel : Funcionario
{
    public Autenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {
    }

    public override double GetBonificacao()
    {
        throw new NotImplementedException();
    }

    public override double AumentaSalario()
    {
        throw new NotImplementedException();
    }
}