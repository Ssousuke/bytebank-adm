using bytebank_adm.Funcionarios;
using bytebank_adm.SistemaInterno;

namespace bytebank_adm.src.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        protected FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf,
            salario)
        {
            Senha = senha;
        }

        public bool Autenticacao(string senha)
        {
            return Senha.Equals(senha);
        }
    }
}