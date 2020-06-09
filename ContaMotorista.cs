namespace Aula13Uber
{
    public class ContaMotorista
    {
        public string agencia { get; set; }
        public string conta { get; set; }

        public string Cadastrar(){
            return "Conta cadastrada";
        }
        public void Excluir(string resposta){
            System.Console.WriteLine("Deseja excluir sua conta?");
            resposta = System.Console.ReadLine();
            if(resposta == "sim"){
            System.Console.WriteLine($"Sua conta: {conta} foi excluída.");
            }else{
                System.Console.WriteLine($"Sua conta: {conta} não foi excluída.");
            }
        }
    }
}