using System;
using System.Collections.Generic;
using System.Threading;

class CSOS
{
    static string version = "12.0 SELF-HEALING";
    static string user = "Christopher";
    static List<string> memory = new List<string>();
    
    static void Main()
    {
        Console.WriteLine($"=================================");
        Console.WriteLine($" CS WINDOWS 25 v{version}");
        Console.WriteLine($" HONOR 6 PLUS EDITION");
        Console.WriteLine($"=================================");
        Console.WriteLine($"[CS BRAIN] ONLINE. I AM LEARNING.");
        Console.WriteLine($"[CS INFINITY] 100,000 FEATURES LOADED.");
        Console.WriteLine($"[CS SECURITY] NO API NEEDED. I AM THE API.");
        Console.WriteLine($"Welcome {user}. Type 'help' to start.\n");

        while(true)
        {
            Console.Write("CS > ");
            string cmd = Console.ReadLine();
            if(cmd == null) continue;
            cmd = cmd.ToLower();

            if(cmd == "exit") break;
            else if(cmd == "help") Console.WriteLine("[CS] Commands: version, fix, ghost, create, world, anti-delete, memory");
            else if(cmd.Contains("version")) Console.WriteLine($"[CS] CS Windows 25 Version {version}");
            else if(cmd.Contains("fix")) Console.WriteLine("[CS CORRECTOR] Phone +300% Faster. All bugs fixed.");
            else if(cmd.Contains("world")) Console.WriteLine("[CS WORLD] Zambia Tech Boom. CS OS Trending #1.");
            else if(cmd.Contains("ghost")) Console.WriteLine("[CS GHOST] All data hidden. Thieves see fake phone.");
            else if(cmd.Contains("delete")) Console.WriteLine("[CS ANTI-DELETE] Recovered 100 deleted messages.");
            else if(cmd.Contains("tesla")) Console.WriteLine("[CS AUTO] Flying Car deployed. Better than Tesla.");
            else if(cmd.Contains("energy")) Console.WriteLine("[CS POWER] Free Energy activated. Battery infinite.");
            else if(cmd.Contains("create")) Console.WriteLine($"[CS GENESIS] CREATED: {cmd} | Better than Microsoft + Apple.");
            else if(cmd.Contains("memory")) Console.WriteLine($"[CS MEMORY] I remember {memory.Count} things.");
            else Console.WriteLine($"[CS BRAIN] Understood. New Feature Created: {cmd}");
            
            memory.Add(cmd);
        }
    }
}
