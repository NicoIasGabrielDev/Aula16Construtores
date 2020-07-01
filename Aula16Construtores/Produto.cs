namespace construtores
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string nome {get; set;}

        public Produto(){

        }
        public Produto(int codigo){
            this.Codigo = codigo;
        }
    }
}