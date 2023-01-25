using System;
class Programa
{
    static void Main(string[] args)
    {
        string frase = "Projeto 6 - Atribuições de Variáveis";
        Console.WriteLine(frase);

        int idade = 30;
        int idadeAna = idade;

        Console.WriteLine(idadeAna + idade);

        idade = 25;

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}