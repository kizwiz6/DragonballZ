using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonballZ
{
    public static class Introduction
    {
        public static void WelcomeText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"
   _____                        __     ______                   __             
  / ___/____  ____  ____ ___  / /_   / ____/____  _________  __/ /_____  _____
  \__ \/ __ \/ __ \/ __ `__ \/ __/  / /   / __ \/ ___/ __ \/ __/ __/ __ \/ ___/
 ___/ / /_/ / /_/ / / / / / / /_   / /___/ /_/ / /  / /_/ / /_/ /_/ /_/ / /    
/____/\____/\____/_/ /_/ /_/\__/   \____/\____/_/   \____/\__/\__/\____/_/     
        ");

        Console.ResetColor();

        Console.WriteLine("Welcome to Dragon Ball Z Console Application!");
        }
    }
}
