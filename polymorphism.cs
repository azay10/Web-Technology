using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public abstract class Animal
    {
        public abstract void WhatIeat();
        public void WhatIbreathe()
        {
            Console.WriteLine("I breathe oxygen");
        }

    }
    public class Tiger : Animal
    {
        public override void WhatIeat()
        {
            Console.WriteLine("I eat flesh");
        }
    }

    public interface Animals
    { 
        void WhatIeat();
        void WhatIbreathe();
    }
    public class Lion : Animal
    {
        public override void WhatIeat()
        {
            Console.WriteLine("I eat flesh");
        }
    }
        internal class polymorphism
        {
            public void WhoAmI()
            {
                Console.WriteLine("I am empty function");

            }
            public void WhoAmI(string name)
            {
                Console.WriteLine("I am" + name);
            }
            public void WhoAmI(int myRollNumber)
            {
                Console.WriteLine("my roll number is" + myRollNumber);
            }

        }
    }
