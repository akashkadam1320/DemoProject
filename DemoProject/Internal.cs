using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Internalclass
    {
        internal int internalproperty
        {  get; set; }
        internal void show()
        {
            Console.WriteLine("internal porperty:"+internalproperty);
        }
    }
    public class Internal
    {
        static void Main (string[] args) 
        {
            Internalclass instance = new Internalclass();
            instance.internalproperty = 1;
            instance.show(); 
        }
}
}