using bytebank_adm.SistemaInterno;

namespace bytebank_adm.Funcionarios;

public class GerenteDeContas : Autenticavel
{
    public string Senha { get; set; }

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

    public bool Autenticacao(string senha)
    {
        return Senha.Equals(senha);
    }
}