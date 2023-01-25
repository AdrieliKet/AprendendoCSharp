using System;
class Programa
{
    static void Main(string[] args)
    {
        string frase = "Projeto 9 - Laços de Repetição For";
        Console.WriteLine(frase);

        double investimento = 1000;
        double fatorRendimento = 1.005;

        // rendimento de 0.5% (0.005) ao mês

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
                }

            fatorRendimento += 0.001;

        }

        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}