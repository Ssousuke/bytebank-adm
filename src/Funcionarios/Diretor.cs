using bytebank_adm.src.Funcionarios;

namespace bytebank_adm.Funcionarios;

public class Diretor : FuncionarioAutenticavel
{
    public string Senha { get; set; }

    public Diretor(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario, senha)
    {
    }

    public override double AumentaSalario()
    {
        return Salario *= 1.15;
    }

    public override double GetBonificacao()
    {
        return Salario + 0.17;
    }

    public bool Autenticacao(string senha)
    {
        return Senha.Equals(senha);
    }
}