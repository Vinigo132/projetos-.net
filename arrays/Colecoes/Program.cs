using Colecoes.helper;




namespace Colecoes

{
    class Program
    {
        static void Main (string[] args)
        {

            //--------------------------------------------------------FUNCIONALIDADES LINQ--------------------------------------------------------
            // int[] arrayNum = new int[10] {1,4,2,3,34,54,84,4,34,2};

            // var min = arrayNum.Min();
            // var max = arrayNum.Max();
            // var media = arrayNum.Average();
            // var soma = arrayNum.Sum();
            // var diferentes = arrayNum.Distinct().ToArray(); //os q nao sao iguais na lista

            // System.Console.WriteLine($" Maximo: {max}");
            // System.Console.WriteLine($" Minimo: {min}");
            // System.Console.WriteLine($" Média: {media}");
            // System.Console.WriteLine($" Soma: {soma}");
            // System.Console.WriteLine($" DOriginal: {string.Join(",",arrayNum)}");
            // System.Console.WriteLine($" Diferentes/unicos: {string.Join(",",diferentes)}");
            
            
            
            
            
            
            // var numParesQuery = 
            //         from num in arrayNum
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var numParesMetodo = arrayNum.Where(x => x% 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("numeros pares query: " + string.Join(",", numParesQuery));
            // System.Console.WriteLine("numeros pares metodo: " + string.Join(",", numParesMetodo));
            //--------------------------------------------------------FIM LINQ--------------------------------------------------------










            //--------------------------------------------------------FUNCIONALIDADES DICIONARIO:--------------------------------------------------------
            // Dictionary<string,string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "SAO PAULO");
            // estados.Add("MG", "MINAS GERAIS");
            // estados.Add("BA", "BAHIA");

            //  foreach (KeyValuePair<string,string> item in estados)
            //  {
            //      System.Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
            //  }

            // string chaveProcurada = "BA";
            //var teste = estados["SC"]; //erro proposital

            // if (estados.TryGetValue(chaveProcurada, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }
            // else
            // {
            //     System.Console.WriteLine("{0} nao existe", chaveProcurada);
            // }

            // System.Console.WriteLine($"remeovendo o valor: {chaveProcurada}");
            // estados.Remove(chaveProcurada);


            // foreach (KeyValuePair<string,string> item in estados)
            //  {
            //      System.Console.WriteLine($"chave: {item.Key}, valor: {item.Value}");
            //  }

            // System.Console.WriteLine("valor original:");
            // System.Console.WriteLine(estados[chaveProcurada]);

            // estados[chaveProcurada] = "baheaaaa ";

            // System.Console.WriteLine("atualizaçao:");
            // System.Console.WriteLine(estados[chaveProcurada]);
            //--------------------------------------------------------FIM DICIONARIO--------------------------------------------------------





            //--------------------------------------------------------FUNCIONALIDADES DA PILHA:------------------------------------------------------------------------------------------
            // Stack<string> pilha = new Stack<string>();

            // pilha.Push("garfo");
            // pilha.Push("faca");
            // pilha.Push("colher");

            // while(pilha.Count > 0)
            // {
            //     System.Console.WriteLine($"prox elemento: {pilha.Peek()}");
            //     System.Console.WriteLine($"{pilha.Pop()} retirado");
            // }

            // System.Console.WriteLine("elementos na pilha: {0}", pilha.Count);
            //--------------------------------------------------------FIM DA PILHA--------------------------------------------------------






            //-------------------------------------------------------- FUNCIONALIDADE DA FILA:--------------------------------------------------------
            // Queue<string> fila = new Queue<string>();

            // fila.Enqueue("mauro");
            // fila.Enqueue("cesar");
            // fila.Enqueue("coelho");

            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");
            // }

            // System.Console.WriteLine("Pessoas na fila: {0}", fila.Count);
            //--------------------------------------------------------FIM DA FILA--------------------------------------------------------
            
            
            //--------------------------------------------------------FUNCIONAMENTO DA LISTA:--------------------------------------------------------
            // opLista opLista = new opLista();
            // List<string> estados = new List<string>();

            // string[] estadosArray = new string[2] {"SC", "MT"};
            // estados.Add("SP");
            // estados.Add("MG");
            // estados.Add("BA");

            // System.Console.WriteLine("Quant de elemntos na lista: {0} ",estados.Count );

            // opLista.ImprimirLista(estados);
            // System.Console.WriteLine("    ");

            // //estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ"); // ADICIONAR EM ALGUM LOCAL ESPECIFICO

            // opLista.ImprimirLista(estados);

            
            
            
            
            
            
            // estados.Remove("MG");

            // System.Console.WriteLine("REMOVENDO MG");

            // opLista.ImprimirLista(estados);
            //--------------------------------------------------------FIM DA LISTA--------------------------------------------------------




            //--------------------------------------------------------FUNCOES ARRAY--------------------------------------------------------
            // OpArrays op = new OpArrays();
            // int[] array = new int[8] {6,3,2,8,4,6,2,19};
            // int[] arrayCopia = new int[16];

            // string[] arrayString = op.ConverterArray(array);




            //int valorP = 19;

            // System.Console.WriteLine("capacidade do array: {0}", array.Length);

            // op.mudarArray(ref array, array.Length + 2);
            // System.Console.WriteLine("novo tamanho: {0}", array.Length);



            // int indice = op.ObterIndice(array, valorP);

            // if(indice > -1)
            // {
            //     System.Console.WriteLine("indice de {0} : {1}", valorP, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("n encontrado");
            // }



            // int valorAchado = op.obterValor(array, valorP);

            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("encontrado");
            // }
            // else
            // {
            //     System.Console.WriteLine("nao encontrado");
            // }



            // bool todosMaior = op.todosMaior(array, valorP);

            // if(todosMaior)
            // {
            //     System.Console.WriteLine("todos maior q: {0}", valorP);
            // }
            // else
            // {
            //     System.Console.WriteLine(" pelo menos um menor q {0}", valorP);
            // }




            // bool existe = op.Existe(array,valorP);

            // if(existe)
            // {
            //     System.Console.WriteLine("valor encontrado: {0}", valorP);
            // }
            // else
            // {
            //     System.Console.WriteLine("nao encontrado: {0}", valorP);
            // }



            // System.Console.WriteLine("array original");
            // op.ImprimirArray(array);

            // //op.ordenarBubbleSort(ref array);
            // //op.ordenar(ref array);

            // System.Console.WriteLine("ordenado: ");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("antes copia: ");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("dps da copia");
            // op.ImprimirArray(arrayCopia);
            //--------------------------------------------------------FIM ARRAY--------------------------------------------------------










        }


    //--------------------------------------------------------FUNCIONALIDADES MATRIZ:--------------------------------------------------------
    //     int[,] matriz = new int[4,2]
    //     {
    //         {8,8},
    //         {40, 53},
    //         {90,89},
    //         {78,62}
    //     };

    //     for (int i = 0; i < matriz.GetLength(0); i++)
    //     {
    //         System.Console.WriteLine("");
    //         for (int j = 0; j < matriz.GetLength(1); j++)
    //         {
    //             System.Console.Write(matriz[i , j]);
    //             System.Console.Write(" ");
    //         }
    //     }
    //--------------------------------------------------------FIM MATRIZ--------------------------------------------------------




        //--------------------------------------------------------FUNCIONALIDADES ARRAYS--------------------------------------------------------
        //    int[] arrayInteiros = new int[3];

        //     arrayInteiros[0] = 9;
        //     arrayInteiros[1] = 24;
        //     arrayInteiros[2] = 69;

        //     for (int i = 0; i < arrayInteiros.Length; i++)
        //     {
        //         System.Console.WriteLine(arrayInteiros[i]);
        //     }
        //     System.Console.WriteLine("foreach");
        //     foreach (int item in arrayInteiros)
        //     {
        //         System.Console.WriteLine(item);
        //     }
        //--------------------------------------------------------FIM ARRAY--------------------------------------------------------



    }
}