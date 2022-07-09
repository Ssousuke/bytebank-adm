namespace bytebank.Funcionario;

public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; private set; }

    public Funcionario(string nome, string cpf, double salario)
    {
        Nome = nome;
        CPF = cpf;
        Salario = salario;
    }

    public virtual double GetBonificacao()
    {
        return Salario * 0.10;
    }
}