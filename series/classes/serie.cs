namespace series
{
    public class Serie : entidadeBase
    {
        //atributos

        public Genero Genero { get; set; }
        public string? Titulo { get; set; }  
        public string? Descriçao { get; set; }   
        public int Ano { get; set; }
        private bool Excluido {get; set;}

    

        //metodo

        public Serie(int id, Genero genero, string titulo, string descriçao,int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descriçao = descriçao;
            this.Ano = ano;
            this.Excluido = false; 
        } 

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descriçao: " + this.Descriçao + Environment.NewLine;
            retorno += "Ano de ínicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno; 
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }

        public void Exclui()
        {
            this.Excluido = true;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }
  

        
    }
}