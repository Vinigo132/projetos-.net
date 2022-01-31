using System;
namespace ExemploPOO.Models
{
    public class aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}.");

        }
    }
}