using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.anastasiabutevich.task1
{
    public class BluePrint : ColorPrint{
        public void coloredPrint(string value){

           Console.WriteLine(value.GetType().Name, 
               Console.ForegroundColor = ConsoleColor.Red);
        }
    }
}
