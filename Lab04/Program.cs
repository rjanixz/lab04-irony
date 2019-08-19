using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluator evaluator = new Evaluator();
            Start start = evaluator.evaluate("20(10(5(20)))");

            Console.WriteLine(start.printTree());

            Console.WriteLine("-");

            Console.WriteLine(start.printMirrorTree());


            Console.WriteLine("El arbol es degenerado? " + start.isDegenerated());

             Console.WriteLine("Se repite? " + start.seReipte());
        }
    }
}
