﻿using System;
using Exploration;

namespace FrameWorkExploration {
    internal class Program {
        static void Main(string[] args) {
            
            var pwd = new PasswordManager();
            pwd.Run();
            Console.ReadLine();
        }
    }
}
