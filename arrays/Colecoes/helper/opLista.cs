

namespace Colecoes.helper
{
    public class opLista
    {
       public void ImprimirLista(List<string> lista)
       {
           for (int i = 0; i < lista.Count; i++)
           {
               System.Console.WriteLine($"Indice {i}, valor: {lista[i]}");
           }
       } 
    }
}