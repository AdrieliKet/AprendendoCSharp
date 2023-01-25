using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos");
        double salario = 3000.1;
        Console.WriteLine("Salário: " + salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine("Salário Inteiro: " + salarioInteiro);

        long x = 20000000000;
        Console.WriteLine(x);

        short y = 15000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}