using DemoProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class PublicDemo
    {
        public void ShowMeassge()
        {
            Console.WriteLine("Hello from publicDemo");
        }
    }
        class PrivateDemo
        {
            private void ShowSecret()
            { 
                Console.WriteLine("This is a secret method");
            }
            public void AccessPrivateMethod()
            {
                ShowSecret();
            }
        }
    class InternalDemo
    {
        internal void showInternalMessage()
        {
            Console.WriteLine("This is an internal method");
        }
    }
    }
     class AccessModifier

    {
            static void Main()
            {
              PublicDemo obj = new PublicDemo();
              obj.ShowMeassge();
              PrivateDemo demo = new PrivateDemo();
              demo.AccessPrivateMethod();
              InternalDemo demo1 = new InternalDemo();
              demo1.showInternalMessage();

        

            }
}
    

