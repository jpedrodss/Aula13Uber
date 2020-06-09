using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Usuario user = new Usuario();
            Corrida corrida = new Corrida();
            Passageiro eu = new Passageiro();
            Cartao visa = new Cartao();

            user.Nome = "João";
            System.Console.WriteLine("Digite seu login:");
            string login = Console.ReadLine();

            System.Console.WriteLine("\nDigite sua senha:");
            string senha = Console.ReadLine();

            user.Login(login, senha);

            if(user.TokenLogin != "" && user.TokenLogin != null){
                
                System.Console.WriteLine("Logado com sucesso.\n");
                visa.Cadastrar();

                System.Console.WriteLine(eu.ProcurarMotorista());

                System.Console.WriteLine("Digite o endereço para embarcar:");
                corrida.LocalInicio = Console.ReadLine();
                System.Console.WriteLine("\nDigite o endereço destino:");
                corrida.LocalChegada = Console.ReadLine();

                corrida.StatusCorrida = "em andamento";
                System.Console.WriteLine($"\nCorrida {corrida.StatusCorrida} e {eu.Pagar(corrida.StatusCorrida)}");

            }else{
                System.Console.WriteLine("Login não efetuado.");

            }



        }
    }
}
