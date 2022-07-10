using bytebank_adm.Funcionario;
using bytebank_adm.Utilitario;

namespace bytebank_adm;

public class Program
{
    static void Main(string[] args)
    {
        Funcionario.Funcionario dir = new Diretor("Wesley Silva", "555.555.555-01", 5000.0);
        GerenciadorDeBonificacao gr = new GerenciadorDeBonificacao();
        gr.RegistrarBonificaco(dir);

        Console.WriteLine($"Total Bonificação: {gr.TotalBonificacao}");
        Console.WriteLine($"Total de Funcionarios: {Funcionario.Funcionario.TotalDeFuncionarios}");
    }
}