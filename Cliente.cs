namespace Aula20_Sprint4_Fixacao3
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string Endereco {get; set;}

        public Cliente(string _nome, string _endereco){
            this.Nome = _nome;
            this.Endereco = _endereco;
        }
        public string MostrarDados(){
            return $"Cliente: {Nome} \nEndereco: {Endereco} \n";
        }
    }
}