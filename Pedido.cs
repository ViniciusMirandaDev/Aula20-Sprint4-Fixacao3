namespace Aula20_Sprint4_Fixacao3
{
    public class Pedido
    {
         public string [] itens=new string[3]{"Hamburguer","Refri","Sorvete"};
        public string Cliente {get; set;}
        public string Restaurante {get; set;}
        public string FormaPGTO;
        public bool PedidoPago;
        public string EntregarPedido(){
            return "Pedido entregue";
        }
    }
}