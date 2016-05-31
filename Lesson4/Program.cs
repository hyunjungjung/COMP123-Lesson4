using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    /**
     * This class is the "driver" class for our Program
     * 
     * @class Program
     */
    public class Program
    {
        /**
         * the main method for our driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create a new instance of the Person Class
            Person jason = new Person();
            jason.Name = "Jason";
            jason.Age = 26;
            jason.SaysHello();
            jason.ShowAge();

            Console.WriteLine();

            Person joanne;
            joanne = new Person("Joanne");
            joanne.Age = 29;
            joanne.SaysHello();
            joanne.ShowAge();

            Console.WriteLine();

            Person angela = new Person(30);
            angela.Name = "Angela";
            angela.SaysHello();
            angela.ShowAge();

            Console.WriteLine();

            Person sue = new Person("Sue", 23);
            sue.SaysHello();
            sue.ShowAge();

        }

    }
}
