namespace Aula20_Sprint4_Fixacao3
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string EnderecoAtual {get; set;}

        public Cliente(string _nome, string _enderecoatual){
            this.Nome = _nome;
            this.EnderecoAtual = _enderecoatual;
        }
        public string MostrarDados(){
            return $"O nome do(a) cliente é {Nome} e se localiza no(a) {EnderecoAtual}";
        }
    }
}