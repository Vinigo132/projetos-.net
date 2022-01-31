namespace ExConstrutores.models
{
    public class matematica
    {
        public int X { get; set; }  
        public int Y { get; set; }  

        public matematica(int x, int y)
        {
            X = x;
            Y = y;

            calculadora.EventCalc += EventHandler;
            
        }

        public void sOMAR()
        {
            calculadora.Somar(X,Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("metodo exec");
        }
    }
}