﻿using System;

namespace T4
{
    internal static class Program
    {
        public static void Main()
        {
            string text = new CSharpCode().TransformText();
            Console.WriteLine(text);
        }
    }
}