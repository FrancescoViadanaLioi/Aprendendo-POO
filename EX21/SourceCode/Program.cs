using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\ProjetosTi\C#\POO\EX21";

        Console.WriteLine($"Initializing copy...");
        try
        {
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, ".", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS:");
            foreach (string s in folders)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Criando pasta...");
            Directory.CreateDirectory(@"C:\ProjetosTi\C#\POO\EX21\Teste01");
            Console.WriteLine("Pasta criada com sucesso.");
        }
        catch (IOException e)
        {
            Console.WriteLine($"This folder doesn't exist: {e.Message}");
        }
        finally
        {
            Console.WriteLine(Path.GetTempPath());
        }
    }
}