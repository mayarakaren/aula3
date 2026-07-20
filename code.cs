using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bem-vindo à Delegacia 99!");
		
        Console.WriteLine("Digite o nome do suspeito:");
        string suspeito = Console.ReadLine();

        Console.WriteLine("Qual é a idade do suspeito?");
        string idadeTexto = Console.ReadLine();
        int idade = int.Parse(idadeTexto);

        Console.WriteLine("Foi preso mais de uma vez? Aperte: v - Verdadeiro ou f - Falso");
        string casosTexto = Console.ReadLine();
        bool casos = (casosTexto == "v");

        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine("No ano que vem você terá " + (idade + 1) + " anos!");
        Console.WriteLine("Foi preso mais de uma vez? " + casos);
    }
}