using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pc
{

    abstract class p1
    {
        public int x, y, z;
        public p1()
        {
            x = 10; y = 20; y = 5;
        }
        public abstract int sum();

    }

    abstract class c1 : p1
    {
        public new int z;
        public new int y;
        public c1()
        {
            y = 30; z = 50;
        }
        public override int sum()
        {
            return x + y + z;
        }

    }

    class p
    {
        public int x;   
        public int y; 
        private int z; 
        int a;     
        public p()
        {
            x = 10; y = 20; z = 100; a = x;
        }
        public virtual string MyString(string s)
        {
            return "MyString " + s;
        }
    }

    sealed class sealedp
    {
        public int x;   
        protected int y; 
        private int z;  
        int a;   
        public sealedp()
        {
            x = 10; y = 20; z = 100; a = x;
        }
    }

    class c: p
    {
        public int z;
        public new int y;
        public c()
        {
            y = 30; z = 50;
        }
        public override string MyString(string s)
        {
            return "Overrided string " + s;
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            p p = new p();
            c c = new c();
            Console.WriteLine("p x, y: {0} {1}", p.x, p.y);
            Console.WriteLine("с x, y, z: {0} {1} {2}", c.x, c.y, c.z);
            Console.ReadLine();
        }
    }
}