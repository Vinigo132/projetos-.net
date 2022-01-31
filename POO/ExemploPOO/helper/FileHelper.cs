
using System.IO;
namespace ExemploPOO.helper
{ 

    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        
        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }   

        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho, apagarArquivos);
        }

        public void CriarTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }

        }



        public void CriarTxt2(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho))
            foreach (var linha in conteudo)
            {
                stream.WriteLine(linha);
            }
        }


        public void Addtext(string caminho,string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AddtextStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho))
            foreach (var linha in conteudo)
            {
                stream.WriteLine(linha);
            }
        }

        public void Ler(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
        
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        
        }

        public void lerstream(string caminho)
        {
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
                 
            }
        }

        public void mover(string caminho, string caminho22)
        {
            File.Move(caminho,caminho22);
        }

        public void copiar(string caminho, string caminho22, bool sob)
        {
            File.Copy(caminho, caminho22, sob);
        }

        public void del( string caminho)
        {
            File.Delete(caminho);
        }

    }
}