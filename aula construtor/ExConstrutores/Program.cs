using ExConstrutores.models;

namespace ExConstrutores
{
    class Program
    {
        public delegate void Op(int x, int y);
        static void Main(string[] args)
        {
            
            matematica M  = new matematica(10,30);
            M.sOMAR();
            
            
            
            
            //Op op2 = calculadora.Somar;
            //op2 += calculadora.Sub;
            //Op op1 = calculadora.Sub;
            //Op op1 = new Op(calculadora.Somar);
            //op2.Invoke(10,50);
            //op1(40,74);

            
            
            
            
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);
            
            
        
            
            // Pessoa p1 = new Pessoa();
            // p1.Apresentar();


            // data data = new data();
            // data.SetMes(14);

            // data.ApesentarMes();

            // data.Mes = 11;
            // System.Console.WriteLine(data.Mes);





            // Log log = Log.GetInstance();

            // log.PropLog = "teste instancia";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropLog);
            
            //  aluno p1 = new aluno("pica", "pau", "alo");
            //  p1.Apresentar();
        }
    }
} 