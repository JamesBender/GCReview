using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLibrary
{
    public abstract class Animal
    {
        public abstract string Speak();

        public virtual void Eat()
        {
            //nom nom nom

            return;
        }
    }

    public class Dog : Animal
    {
        public override string Speak()
        {
            return "Bark!";
        }
    }

    public class Bird : Animal, IFly
    {
        public override string Speak()
        {
            return "Chirp!";
        }

        public string Fly()
        {
            return "flap, flap, flap!";
        }
    }

    public class Helicopter : IFly
    {
        public string Fly()
        {
            return "Whirrrrr";
        }
    }

    public interface IFly
    {
        string Fly();
    }
}
