namespace ExConstrutores.models
{
    public class Pessoa
    {
        private readonly string nome = "jao";
        private readonly string sobrenome;

         public Pessoa()
         {
             //nome = string.Empty;
             sobrenome = "micao";

         }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("cons da pessoa");
        }


        public void Apresentar()
        {
            System.Console.WriteLine($"meu nome é: {nome} {sobrenome}");
        }

    }
}