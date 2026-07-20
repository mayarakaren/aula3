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

        Console.WriteLine("É reincidente? Aperte: v - Verdadeiro ou f - Falso");
        string reincidenteTexto = Console.ReadLine();
        bool reincidente = (reincidenteTexto == "v");

        Console.WriteLine("Qual a letra da divisão que investiga o caso?");
        string divisaoTexto = Console.ReadLine();
        char divisao = Convert.ToChar(divisaoTexto);

        int anosParaTrinta = 30 - idade;

        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine("Faltam " + anosParaTrinta + " anos para o suspeito completar 30 anos.");
        Console.WriteLine("Ficha: " + suspeito + ", " + idade + " anos, reincidente: " + reincidente + ", Divisão " + divisao);
    }
}