namespace Aula20_Sprint4_Fixacao3
{
    public class Restaurante
    {
         public string NomeFantasia {get; set;}
        public string Endereco {get; set;}

        public Restaurante(string _nomeFantasia, string _endereco){
            this.NomeFantasia = _nomeFantasia;
            this.Endereco = _endereco;
        }
        public string MostrarDados(){
            return $"O nome do restaurante é {NomeFantasia} e se localiza no(a) {Endereco}";
        }
    }
}