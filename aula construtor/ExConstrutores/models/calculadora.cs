namespace ExConstrutores.models
{
    public class calculadora
    {
        //delegate
        public delegate void DeleCalc();
        
        //evento
        public static event DeleCalc EventCalc;




        public static void Somar(int x, int y)
        {
            if(EventCalc != null)
            {
                System.Console.WriteLine($"add: {x + y}");
                EventCalc();
            }
            else
            {
                System.Console.WriteLine("ngm inscrito");
            }
            
        }

        public static void Sub(int x, int y)
        {
            System.Console.WriteLine($"sub: {x-y}");
        }
    }
}