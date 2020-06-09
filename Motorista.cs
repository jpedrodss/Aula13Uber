namespace Aula13Uber
{
    public class Motorista : Usuario
    {
        private string ModeloDoCarro { get; set; }
        private string PlacaDoCarro { get; set; }

        public void AceitarPassageiro(string nome){
            System.Console.WriteLine($"Você aceitou uma corrida para {LocalChegada}.");
        }
        public string ReceberPagamento(string statusCorrida){
            if(statusCorrida == "Finalizada."){
                return "Você recebeu o dinheiro da corrida!";
            }

            return "O pagamento será feito quando a corrida for finalizada.";
        }
    }
}