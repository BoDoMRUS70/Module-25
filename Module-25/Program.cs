﻿using Module_25.Repositories;

namespace Module_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext())
            {
                Console.WriteLine("Hello, World!");
            }
        }
    }
}