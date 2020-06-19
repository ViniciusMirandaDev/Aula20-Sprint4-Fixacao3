using System;

namespace Aula20_Sprint4_Fixacao3
{
    class Program
    {
        static void Main(string[] args)
        {   

            Cliente jose = new Cliente("José", "Rua das palmeiras n° 132");
            jose.MostrarDados();
            System.Console.WriteLine(jose.MostrarDados());

            Restaurante labola =new Restaurante("LaBola","Avenida dos flascos n° 543");
            labola.MostrarDados();
            System.Console.WriteLine(labola.MostrarDados());

            Pedido comida= new Pedido();
            comida.Cliente= jose;
            comida.Restaurante= labola;
            
            
            System.Console.WriteLine(comida.EntregarPedido());            
        }
    }
}
