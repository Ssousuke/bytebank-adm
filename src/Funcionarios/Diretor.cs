namespace bytebank_adm.Funcionarios;

public class Diretor : Funcionario
{
    public string Senha { get; set; }

    public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
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

    public bool Autenticacao(string login, string senha)
    {
        return Senha.Equals(senha) || CPF.Equals(login);
    }
}