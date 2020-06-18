using System;

namespace Aula20_Sprint4_Fixacao3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Pedido comida= new Pedido();
            Restaurante labola =new Restaurante("LaBola","Avenida dos flascos n° 543");
            Cliente jose = new Cliente("José", "Rua das palmeiras n° 132");

            jose.MostrarDados();
            System.Console.WriteLine(jose.MostrarDados());

            labola.MostrarDados();
            System.Console.WriteLine(labola.MostrarDados());

            comida.Cliente= jose.Nome;
            comida.Restaurante= labola.NomeFantasia;
            
            
            
            
            System.Console.WriteLine(comida.EntregarPedido());



            


            
        }
    }
}
