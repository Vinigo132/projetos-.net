using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "4")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe nota do aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} --> NOTA: {a.Nota} ");
                            }
                            
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for(int i=0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        conceito conceitoGeral;

                        if ( mediaGeral < 2)
                        {
                            conceitoGeral = conceito.E;
                        }
                        else if ( mediaGeral < 4)
                        {
                            conceitoGeral = conceito.D;
                        }
                        else if ( mediaGeral < 6)
                        {
                            conceitoGeral = conceito.C;
                        }
                        else if ( mediaGeral < 8)
                        {
                            conceitoGeral = conceito.B;
                        }
                        else
                        {
                            conceitoGeral = conceito.A;
                        }



                        Console.WriteLine($"MÉDIA GREAL: {mediaGeral.ToString("N2")} --> CONCEITO: {conceitoGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opcao desejada: ");
            Console.WriteLine("1- inserir novo aluno");
            Console.WriteLine("2- listar alunos");
            Console.WriteLine("3- calcular media geral");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}