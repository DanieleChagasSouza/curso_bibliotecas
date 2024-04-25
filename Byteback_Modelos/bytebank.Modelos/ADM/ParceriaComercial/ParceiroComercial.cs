using Byteback_Modelos.bytebank.Modelos.ADM.Utilitario;
using bytebank.Modelos.ADM.SistemaInterno;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        private AuteticacaoUtil Autenticador  = new AuteticacaoUtil();
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidaSenha(this.Senha, senha);
        }
    }
}
