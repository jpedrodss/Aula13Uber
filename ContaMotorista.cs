namespace Aula13Uber
{
    public class ContaMotorista
    {
        public string agencia { get; set; }
        public string conta { get; set; }

        /// <summary>
        /// Cadastra uma conta bancária do motorista
        /// </summary>
        /// <returns>Mensagem informando sucesso no cadastro</returns>
        public string Cadastrar(){
            return "Conta cadastrada!";
        }
        /// <summary>
        /// Exclui a conta bancária do motorista
        /// </summary>
        public void Excluir(){
            System.Console.WriteLine($"Sua conta: {conta} foi excluída.");
        }
    }
}