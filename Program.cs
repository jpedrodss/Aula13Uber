using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Usuario user = new Usuario();
            // System.Console.WriteLine("Digite seu login:");
            // string login = Console.ReadLine();

            // System.Console.WriteLine("\nDigite sua senha:");
            // string senha = Console.ReadLine();

            // user.Login(login, senha);

            // if(user.TokenLogin != "" && user.TokenLogin != null){
            //     System.Console.WriteLine("Logado com sucesso.\n");
            // }else{
            //     System.Console.WriteLine("Usuário deslogado.\n");
            // }

            user.Nome = "João";

            Motorista motorista = new Motorista();
            System.Console.WriteLine(motorista.AceitarPassageiro(user.Nome));
        }
    }
}
