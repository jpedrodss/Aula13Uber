namespace Aula13Uber
{
    public class Passageiro
    {
        public string ProcurarMotorista(){
            return "Procurando motoristas disponíveis";
        }
        public string Pagar(string statusCorrida){
            if(statusCorrida == "Finalizada."){
                return "Pago!";
            }

            return "Pagamento será feito quando a corrida for finalizada.";
        }
    }
}