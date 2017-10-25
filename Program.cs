using System;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
           carro carro1 = new carro ();
           carro1.cor = "Vermelho";
           carro1.ano = 2017;
           carro1.modelo = "Focus";

        //    Console.WriteLine(carro1.cor + " " + carro1.ano + " " + carro1.modelo + " ");

           carro1.MostrarDados(carro1.cor, carro1.modelo, carro1.ano);

           carro carro2 = new carro ();
           carro2.LigarCarro();
           
        }
    }
}
