namespace Shape
{
    public class Program
    {
        static void Main(string[] args)
        {
            shape s=new sequre(12);
            shape c=new circle(3);
            shape t=new tringle(10,23);
            shape r=new rectangle(5,3);

            Console.WriteLine($"Area of Square: {s.area()}");
            Console.WriteLine($"Area of Circle: {c.area()}");
            Console.WriteLine($"Area of Triangle: {t.area()}");
            Console.WriteLine($"Area of Rectangle: {r.area()}");
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
    public class sequre :shape { 
    
      public sequre(double lentgh)
        {
            this.lentgh = lentgh;
         

        }
     public override double area()
        {
          
            return lentgh*lentgh;
        }
    }
    public class circle :shape {
    
     public circle(double r)
        {
            this.lentgh = r;
        }
        public override double area()
        {
            return Math.PI*(lentgh* lentgh);
        }

    }
    public class tringle :shape {

        public tringle(double length,double hieght)
        {
            this.lentgh=length;
            this.width=hieght;

        }
        public override double area()
        {
            return (1.0/2) * lentgh * width;
        }
    }
    public class rectangle :shape {

        public rectangle(double lentgh,double width)
        {
            this.width = width;
            this.lentgh=lentgh;
        }
        public override double area()
        {
            return lentgh*width;

        }


    }
}
