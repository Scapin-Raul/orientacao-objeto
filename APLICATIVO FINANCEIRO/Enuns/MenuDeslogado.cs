namespace APLICATIVO_FINANCEIRO.Enuns
{
    public class MenuDeslogado
    {
        public enum MenuSemLogin : uint{
            CRIAR_CONTA,
            LOGAR,
            LISTAR_USUARIOS,
            SAIR,
        };
        public enum MenuComLogin : uint{
            CADASTRAR_TRANSAÇÃO,
            EXIBIR_EXTRATO,
            RELATORIO,
            EXPORTAR_BANCO_DE_DADOS,
            SAIR,
        };

    }
}