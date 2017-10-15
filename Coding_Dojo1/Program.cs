using System;

using System.Linq;
using System.Text;
using Coding_Dojo1.Stack;

namespace Coding_Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestWithInt();
            TestWithObject();
            //TestWithString();

            Console.ReadLine();
            

        }

        private static void TestWithInt()
        {

            Stack<int> test = new Stack<int>();
            test.push(1);
            test.push(2);
            test.push(3);
            Console.WriteLine("current: {0}", test.peek());
            Console.WriteLine("deleted: {0}", test.pop());
            Console.WriteLine("current: {0}", test.peek());
            Console.WriteLine("deleted: {0}", test.pop());
            Console.WriteLine("deleted: {0}", test.pop());
            test.push(5);
            test.push(6);
            test.push(7);
            Console.WriteLine("current: {0}", test.peek());
        }

        private static void TestWithString()
        {
            Stack<string> test = new Stack<string>();
            test.push("Hello");
            Console.WriteLine("current: {0}", test.peek());
            test.push("from");
            Console.WriteLine("current: {0}", test.peek());
            test.push("the");
            Console.WriteLine("current: {0}", test.peek());
            test.push("other");
            Console.WriteLine("current: {0}", test.peek());
            test.push("side!");
            Console.WriteLine("current: {0}", test.peek());
            test.push("no more text!");
            Console.WriteLine("deleted: {0}", test.pop());
            Console.WriteLine("deleted: {0}", test.pop());


        }

        private static void TestWithObject()
        {
            Stack<SomeObject> product = new Stack<SomeObject>();
            product.push(new SomeObject(500,"Samsung"));
            Console.WriteLine("current: {0}", product.peek());
            product.push(new SomeObject(200, "LG"));
            product.push(new SomeObject(800, "Apple"));
            Console.WriteLine("current: {0}", product.peek());
            product.push(new SomeObject(300, "Panasonic"));
            Console.WriteLine("deleted: {0}", product.pop());




        }
    }
}
