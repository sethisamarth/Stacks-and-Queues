﻿using System;
using System.Collections;

namespace StacksQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Stack Operations-------------");
            Console.WriteLine("***1.Push operation***");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            System.Collections.Stack stack = new System.Collections.Stack();
            switch (num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
