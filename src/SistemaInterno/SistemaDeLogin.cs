using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public class SistemaInterno
{
    public bool Logar(Diretor funcionario, string login, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticacao(login, senha);
        return usuarioAutenticado;
    }
}