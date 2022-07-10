namespace bytebank_adm.Funcionarios;
public abstract class Funcionario
{
    public string Nome { get; }
    public string CPF { get; }
    public double Salario { get; protected set; }
    public static int TotalDeFuncionarios { get; private set; }

    public Funcionario(string nome, string cpf, double salario)
    {
        Nome = nome;
        CPF = cpf;
        Salario = salario;
        TotalDeFuncionarios++;
    }

    public abstract double GetBonificacao();


    public abstract double AumentaSalario();
}