namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        private string login = "joao@pedro.com";
        private string senha = "batata";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        /// <summary>
        /// Loga o usuário no sistema
        /// </summary>
        /// <param name="login">login do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Se login pode ou não ser efetuado</returns>
        public bool Login(string login, string senha){
            if(this.login == login && this.senha == senha){
                TokenLogin = "89j234fh7802hjhduihqad198431hasbhfjkdsa87324";
                return true;
            }
            return false;
        }
        /// <summary>
        /// Desloga o usuário do sistema
        /// </summary>
        public void Logout(){
            TokenLogin = "";
            System.Console.WriteLine("Logout feito com sucesso!"); 
        }
    }
}