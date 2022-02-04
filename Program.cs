using System;
using SwordArtOnline.src.Entities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silica sili = new Silica ("sili",12,"Frágil");
            Spiegel spi = new Spiegel("spi",16,"Camuflado");

            Console.WriteLine(sili.Attack(3));
            Console.WriteLine(spi.Attack(3));

        }
    }
}
