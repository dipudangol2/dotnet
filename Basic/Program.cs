using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Geoshape; //importing Geoshape namespace
namespace Basic
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal: Eat()");
        }
    }

    public class Cat : Animal
    {
        //override: redefining same method in child class changing the whole logic for the method. Uses virtual function 
        //overload: Declaring a method with a same name but changing the parameters.
        //Dynamic Polymorphism
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Cat: Eat()");
        }
    }
    //class initialization


    //enums
    public enum Direction//they are converted into index when converted
    {
        NORTH,
        SOUTH, 
        EAST,
        WEST,
        
    };

    internal class Program
    {
        static void increment(ref int count)
        {
            count += 1;
        }
        static void Main(string[] args)
        {
            /*
            Animal a = new Animal();
            a.Eat();
            Cat c = new Cat();
            c.Eat();
             */
            Direction value = Direction.NORTH;
            int num = (int)Direction.SOUTH;
            Console.WriteLine(value);
            Console.WriteLine(num);
            /*Properties p = new Properties();
            Console.WriteLine(p.X);
            p.X = 5;
            Console.WriteLine(p.X);

            int count = 0;
            SimpleInterest I = new SimpleInterest(150000, 5.9, 3);
            I.PrintInterest();
            Console.WriteLine(count);
            while (count <= 5)
            {
                increment(ref count);
            }
            Console.WriteLine(count);
            Box box = new Box(5, 7, 9);
            box.PrintArea();
            Box.PrintMe();
            */

            Console.ReadLine();
        }
    }
}
