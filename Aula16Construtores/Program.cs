using System;

namespace construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância com o método construtor sem argumentos
            Produto tenis = new Produto();

            // Instância da sobrecarga do método construtor com 1 argumento
            Produto sandalia = new Produto(324);
            System.Console.WriteLine(sandalia.Codigo);
        }
    }
}
