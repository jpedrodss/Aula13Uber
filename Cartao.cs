namespace Aula13Uber
{
    public class Cartao
    {
        private string Titular { get; set; }
        private string NumeroDoCartao { get; set; }
        private string Bandeira { get; set; }
        private string CVV { get; set; }
        string resposta = null;

        /// <summary>
        /// Cadastra cartão do passageiro para pagamento das corridas
        /// </summary>
        /// <returns>Mensagem informando sucesso no cadastro do cartão</returns>
        public void Cadastrar(){
            System.Console.WriteLine("Deseja cadastrar um novo cartão?");
            resposta = System.Console.ReadLine();
            if(resposta == "Sim"){
                System.Console.WriteLine("Digite o Titular da Conta");
                string Titular = System.Console.ReadLine();
                System.Console.WriteLine($"Cadastro realizado em nome de {Titular} com sucesso!");
            }
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