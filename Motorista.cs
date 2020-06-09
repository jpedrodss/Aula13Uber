namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        private string ModeloDoCarro { get; set; }
        private string PlacaDoCarro { get; set; }

        /// <summary>
        /// Faz com que motorista aceite a corrida do passageiro
        /// </summary>
        /// <param name="nome">Nome do passageiro</param>
        /// <returns>Mensagem informando sucesso em aceitar a corrida</returns>
        public string AceitarPassageiro(){
            return $"Você aceitou uma corrida de ";
        }
        /// <summary>
        /// Verifica se a corrida está finalizada para que o motorista possa receber o pagamento
        /// </summary>
        /// <param name="statusCorrida">Status da Corrida</param>
        /// <returns>Mensagem se foi possível ou não receber o pagamento</returns>
        public string ReceberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizada."){
                return "Você recebeu o pagamento da corrida!";
            }

            return "O pagamento será feito quando a corrida for finalizada.";
        }
    }
}