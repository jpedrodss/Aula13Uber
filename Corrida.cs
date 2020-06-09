namespace Aula13Uber
{
    public class Corrida
    {
        private string LocalInicio { get; set; }
        private string LocalChegada { get; set; }
        private string StatusCorrida { get; set; }
        private string Motorista { get; set; }
        private string Passageiro { get; set; }

        public string Cancelar(){
            return "Sua corrida foi cancelada";
        }
    }
}