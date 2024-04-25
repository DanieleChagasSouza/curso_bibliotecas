
namespace Byteback_Modelos.bytebank.Modelos.ADM.Utilitario;

internal class AuteticacaoUtil
{
    public bool ValidaSenha(string senhaVerdadeira, string senhaTentativa)
    {
        return senhaVerdadeira.Equals(senhaTentativa);
    }
}
