namespace bytebank.Modelos.Conta
{
    public class Cliente
    {
        public Cliente()
        {
            Cpf = string.Empty;
            Nome = string.Empty;
            Profissao = string.Empty;
        }

        public string? Cpf { get; set; }

        private string _nome;
        public string? Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
                }
                _nome = value;
            }
        }

        public string? Profissao { get; set; }

        public static int TotalClientesCadastrados { get; set; }

        public Cliente()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }
    }
}
