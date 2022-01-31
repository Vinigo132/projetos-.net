namespace ExConstrutores.models
{
    public class aluno : Pessoa
    {
        //passando para clase mae:
        public aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)      
        {
            System.Console.WriteLine("classe aluno");
        }
        
    }
}