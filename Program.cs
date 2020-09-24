using System;

namespace Cebolinha_AT_Etec
{
    class Program
    {
        static void Main(string[] args)
        {
        string NomeDoUsuario; 

        string SobreNomeDoUsuario;

        string NomeCompleto;

        string FrasesCebolinha;


            Console.Write("Por Favor, digite seu nome: ");
            NomeDoUsuario = Console.ReadLine();

            Console.Write("Agora digite seu SobreNome: ");
            SobreNomeDoUsuario = Console.ReadLine();

            NomeCompleto = $"{NomeDoUsuario} {SobreNomeDoUsuario}";

            Console.Write($"Ola {NomeCompleto},  Digite para mim alguma frase: ");
            FrasesCebolinha = Console.ReadLine();

            
            Console.WriteLine(FrasesCebolinha.Replace("L" , "R"));
        }
    }
}
