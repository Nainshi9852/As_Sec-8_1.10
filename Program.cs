﻿using System;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
        public static void runApp()
        {
            ST stack = new ST();

            Console.WriteLine("length of stack=" + stack.getLengthOfStack());
            if (stack.peek() == null)
                Console.WriteLine("Stack contains nothing");
            for (int i = 0; i < 10; i++)
            {
                Node n = new Node();
                n.Data = i.ToString();
                stack.push(n);
                Console.WriteLine("Length of stack=" + stack.getLengthOfStack());
            }

            Node node = stack.pop();
            Console.WriteLine("Popped " + node.Data);

            node = stack.pop();
            Console.WriteLine("Popped " + node.Data);

            Console.WriteLine(stack.listContents());
        }
    }
}
    
