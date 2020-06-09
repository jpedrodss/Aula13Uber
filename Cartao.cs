namespace Aula13Uber
{
    public class Cartao
    {
        private string Titular { get; set; }
        private string NumeroDoCartao { get; set; }
        private string Bandeira { get; set; }
        private string CVV { get; set; }

        /// <summary>
        /// Cadastra cartão do passageiro para pagamento das corridas
        /// </summary>
        /// <returns>Mensagem informando sucesso no cadastro do cartão</returns>
        public string Cadastrar(){
            return "Cartão cadastrado";
        }
        /// <summary>
        /// Exclue o cartão do do passageiro
        /// </summary>
        /// <returns>Mensagem informando exclusão do cartão do passageiro</returns>
        public string Excluir(){
            return "Cartão excluído";
        }
    }
}