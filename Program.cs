using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    abstract class Shape
    {
        private float s;
        public float S
        {
            get
            {
                return s;
            }
            set
            {
                if (value >= 0)
                { s = value; }
            }
        }
    }
    class Rectangle : Shape
    {
        public float GetArea(float c, float k)
        {
            return S = c * k;
        }
    }
    class Circle : Shape
    {
        static double PI = 3.1415926;
        public float GetArea(float r)
        {
            return S = Convert.ToSingle(PI * r * r);
        }
    }

    class Triangle : Shape
    {
        public float GetArea(float a, float b, float c)
        {
            float HalfLength = (a + b + c) / 2;
            return S = Convert.ToSingle(Math.Sqrt(HalfLength * (HalfLength - a) * (HalfLength - b) * (HalfLength - c)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            float len, wid, r, a, b, c;
            string option;
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            Console.WriteLine("Choose: 1.Triangle; 2.Rectangle; 3.Circle");
            option = Console.ReadLine();

            if(option == "1")
            {
                Console.WriteLine("Input three sides:");
                a = Convert.ToSingle(Console.ReadLine());
                b = Convert.ToSingle(Console.ReadLine());
                c = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("The area is: {0}", triangle.GetArea(a, b, c));
            }
            else if(option == "2")
            {
                Console.WriteLine("Input length and width:");
                len = Convert.ToSingle(Console.ReadLine());
                wid = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("The area is：{0}", rectangle.GetArea(len, wid));
            }
            else if(option == "3")
            {
                Console.WriteLine("Input radius:");
                r = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("The area is：{0}", circle.GetArea(r));
            }
           
            Console.ReadLine();
        }
    }
}
