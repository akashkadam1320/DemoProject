using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject

{
    // Base Class 
    // Method NAme same Parmeter Aslo same but different class
    class Shape
    {
        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }
    // Derved class
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
        internal class DynamicPolymorphism
    {
        static void Main()
        {
            // Creating Object
            Shape shape1 = new Shape();
            Shape shape2 = new Circle();
            Shape shape3 = new Rectangle();

            // Calling Method form each object
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
        }
    }
}
