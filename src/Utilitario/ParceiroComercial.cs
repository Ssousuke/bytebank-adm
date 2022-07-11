using bytebank_adm.SistemaInterno;

namespace bytebank_adm.src.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        private string Senha;
        public bool Autenticacao(string senha)
        {
            return Senha.Equals(senha);
        }
    }
}