namespace Aula13Uber
{
    public class Cartao
    {
        private string Titular { get; set; }
        private string NumeroDoCartao { get; set; }
        private string Bandeira { get; set; }
        private string CVV { get; set; }

        public string Cadastrar(){
            return "Cartão cadastrado";
        }
        public string Excluir(){
            return "Cartão excluído";
        }
    }
}