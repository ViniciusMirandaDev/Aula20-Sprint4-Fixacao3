namespace Aula20_Sprint4_Fixacao3
{
    public class Pedido
    {
        public string [] Itens=new string[10];
        public string Cliente;
        public string Restaurante;
        public string FormaPGTO;
        public bool PedidoPago;
        public string EntregarPedido(){
            return "Pedido entregue";
        }
    }
}