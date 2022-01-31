using System;
using ExemploPOO.helper;
using ExemploPOO.interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "D:\\projetos.net\\arquivos";
            var caminho23  = Path.Combine(caminho, "Pasta teste 2", "txt teste.txt");
            var caminho2 = Path.Combine(caminho, "pasta 3");
            var caminhotxt  = Path.Combine(caminho, "txt teste.txt");
            var listaString = new List<string> {"linha1", "linha 2", "linha 3"};
            var listaString2 = new List<string> {"linha4", "linha 5", "linha 6"};            
            
            
            FileHelper  helper = new FileHelper();

            //helper.ListarArquivosDiretorios(caminho);
            //helper.ListarDiretorios(caminho);
            //helper.CriarDiretorio(Path.Combine(caminho, "pasta 3", "Sub3"));
            //helper.ApagarDiretorio(caminho2, true);
            //helper.CriarTexto(caminhotxt, "lore ipsum gg");
            //helper.CriarTxt2(caminhotxt, listaString);
            //helper.AddtextStream(caminhotxt, listaString2);
            //helper.lerstream(caminhotxt);
            //helper.mover(caminhotxt, caminho23);
            //helper.copiar()
            helper.del(caminho23);
            
            
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.dividir(100, 20));
            
            
            
            
            
            
            
            
            
            
            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());
            
            
            
            
            
            
            
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            

            // aluno p1 = new aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 10;
            // p1.Apresentar();

            // Professor p2 = new Professor();

            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Salario = 1000;
            // p2.Apresentar();
            
            
            
            
            
            
            
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);

            // System.Console.WriteLine($" Área: {r.ObterArea()}");

            // Retangulo r2 = new Retangulo();
            // r.DefinirMedidas(0, 0);

            // System.Console.WriteLine($" Área: {r2.ObterArea()}");
            
            
            
            

        }
    }
}