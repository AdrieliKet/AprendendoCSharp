using System;
class Programa
{
    static void Main(string[] args)
    {
        string frase = "Projeto 5 - Caracteres e Textos";
        Console.WriteLine(frase);

        char letra = 'a';
        Console.WriteLine(letra);

        //ASCII TABLE
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        // A identação fica desta forma pois se for identado irá acontecer o mesmo no console
        string cursos = @"Cursos diponíveis: 
- Go
- C#
- Java
-Python";

        Console.WriteLine(cursos);
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();

    }
}