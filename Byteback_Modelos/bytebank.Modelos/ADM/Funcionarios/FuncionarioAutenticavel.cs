using Byteback_Modelos.bytebank.Modelos.ADM.Utilitario;
using bytebank.Modelos.ADM.SistemaInterno;


namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {

        private AuteticacaoUtil Autenticador = new AuteticacaoUtil();
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidaSenha(this.Senha, senha);
        }
    }
}
