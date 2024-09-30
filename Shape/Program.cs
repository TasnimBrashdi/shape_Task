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
        protected double r;
        protected double hieght;


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
            this.r = r;
        }
        public override double area()
        {
            return Math.PI*(r* r);
        }

    }
    public class tringle :shape {

        public tringle(double length,double hieght)
        {
            this.lentgh=length;
            this.hieght=hieght;

        }
        public override double area()
        {
            return (1.0/2) * lentgh * hieght;
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
