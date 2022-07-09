using bytebank.Funcionario;

public class Program
{
    static void Main(string[] args)
    {
        Funcionario func = new Funcionario("Wesley Matheus", "555.555.555-00", 2500.0);
        Funcionario dir = new Diretor("Wesley Silva", "555.555.555-01", 5000.0);
        GerenciadorDeBonificacao gr = new GerenciadorDeBonificacao();
        gr.RegistrarBonificaco(func);
        gr.RegistrarBonificaco(dir);

        Console.WriteLine(func.GetBonificacao());
        Console.WriteLine(dir.GetBonificacao());
        Console.WriteLine(gr.TotalBonificacao);
    }
}