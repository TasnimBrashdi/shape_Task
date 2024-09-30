namespace Shape
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class shape
    {
        protected double lentgh;
        protected double width;

        public virtual double area() { 
            
            return 0;
        }
    }
    public class sequre :shape { }
    public class circle :shape { }
    public class tringle :shape { }
    public class rectangle :shape { }
}
