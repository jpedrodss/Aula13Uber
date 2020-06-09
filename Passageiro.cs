namespace Aula13Uber
{
    public class Passageiro : Usuario
    {
        /// <summary>
        /// Procura um motorista para corrida solicitada
        /// </summary>
        /// <returns>Mensagem informando que está a procura de motoristas</returns>
        public string ProcurarMotorista(){
            return "\nProcurando motoristas disponíveis...\n";
        }
        /// <summary>
        /// Verifica se a corrida está finalizada para que possa ser efetuado o pagamento
        /// </summary>
        /// <param name="statusCorrida">Status da Corrida</param>
        /// <returns>Mensagem se foi possível o pagamento ou não</returns>
        public string Pagar(string statusCorrida){
            if(statusCorrida == "Finalizada."){
                return "pagamento efetuado.";
            }

            return "pagamento será feito quando a corrida for finalizada.";
        }
    }
}