using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public interface Logger
    {
        void LogMassage(string message);
    }

    public interface TestLogger
    {
        public void LogTestMessage(string message);
    }
    public class ConsoleLogger : Logger, TestLogger  // Multiple inheritance implement as c# dosenot support we can achive using he interface
    {
        public void LogMassage(string message)
        {
            Console.WriteLine($"Logging the message:{message}");
        }
        public void LogTestMessage(string address)
        {
            Console.WriteLine($"Address is: {address}");

        }
    }

    internal interface TestInterface
    {
        static void Main()
        {
            // createing instance for the child class as we can not create the instance for the interface
            ConsoleLogger cl = new ConsoleLogger();
            cl.LogMassage("Hello World!");

            cl.LogTestMessage("Pune");
        }
    }
}
