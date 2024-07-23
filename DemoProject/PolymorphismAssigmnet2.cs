//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DemoProject
//{
//    class Animal
//    {
//        public virtual void Draw()
//        {
//            Console.WriteLine("Drawing a shape");

//        }
//    }
//    class Circle : Animal
//    {
//        public override void Draw()
//        {
//            Console.WriteLine("Drawing a Circle");
//        }
//    }
//    class Rectangle : Animal
//    {
//        public override void Draw()
//        {
//            Console.WriteLine("Drawing a Rectangle");
//        }
//    }
//    internal class PolymorphismAssigmnet2
//    {
//        static void Main()
//        {
//            Animal animal1 = new Animal();
//            Animal animal2 = new Circle();
//            Animal animal3 = new Rectangle();

//            animal1.Draw();
//            animal2.Draw();
//            animal3.Draw();

//        }
//    }
//}
