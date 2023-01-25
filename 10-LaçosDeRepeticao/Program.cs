using System;
class Programa
{
    static void Main(string[] args)
    {
        string frase = "Projeto 8 - Laços de Repetição";
        Console.WriteLine(frase);

        double investimento = 1000;
        int mes = 1;

        // rendimento de 0.5% (0.005) ao mês

        while(mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
            mes++;
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}