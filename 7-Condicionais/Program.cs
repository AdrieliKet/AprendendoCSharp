using System;
class Programa
{
    static void Main(string[] args)
    {
        string frase = "Projeto 7 - Condicionais";
        Console.WriteLine(frase);

        int idadeJoao = 18;
        int acompanhante = 1;
        bool acompanhado = acompanhante > 0;

        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
            Console.WriteLine("Não pode entrar!");


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}