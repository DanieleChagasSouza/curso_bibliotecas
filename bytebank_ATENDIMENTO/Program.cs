using Byteback_Modelos.bytebank.Modelos.ADM.Utilitario;
using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using ByteBank_GeradorChavePix;
Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//new ByteBankAtendimento().AtendimentoCliente();


Console.WriteLine(GeradorPix.GetChavePix());

var chavesPix = GeradorPix.GetChavesPix(10);

foreach (var chave in chavesPix)
{
    Console.WriteLine(chave);
}