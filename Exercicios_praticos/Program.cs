using System; 

class DIO {

    static void Main(string[] args) { 

     string str;
            while((str=Console.ReadLine())!= null)
            {
                    int x = int.Parse(str);
                    if ( x==0 )
                    {
                    Console.WriteLine("vai ter copa!"   ); 
                    }
                    else
                    {
                        Console.WriteLine("vai ter duas!"  );
                    }
                }
            }

    }



using System; 

class DIO {

    static void Main(string[] args) { 
    int reclamacoes = int.Parse(Console.ReadLine());
    
     while(reclamacoes >= 0 && reclamacoes <= 100 && reclamacoes != null)
     {
        
                if(reclamacoes == 0)
                {
                    System.Console.WriteLine("vai ter copa!");
                }
                else
                {
                    System.Console.WriteLine("vai ter duas");
                }
        int reclamacoes = int.Parse(Console.ReadLine());
            

    }

}
}