using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno;

public class SistemaInterno
{
    public bool Logar(IAutenticavel funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticacao(senha);
        return usuarioAutenticado;
    }
}