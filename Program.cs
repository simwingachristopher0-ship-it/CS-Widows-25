using Terminal.Gui;
using System;
using System.Collections.Generic;
using System.Threading;

class CSOS
{
    static string version = "12.0 SELF-HEALING";
    static string user = "Christopher";
    static List<string> memory = new List<string>();
    static List<string> worldNews = new List<string> { "Peace in Africa", "CS OS Trending #1", "Free Energy Discovered", "Zambia Tech Boom" };
    static Random rnd = new Random();
    static int worldIndex = 0;

    static void Main()
    {
        Application.Init();
        var top = Application.Top;
        
        var win = new Window($"CS WINDOWS 25 v{version} | GOD OS")
        {
            X = 0, Y = 1, Width = Dim.Fill(), Height = Dim.Fill() - 1
        };

        var output = new TextView()
        {
            X = 1, Y = 1, Width = Dim.Fill() - 2, Height = 14,
            ReadOnly = true,
            Text = $"CS BOOTING v{version}...\n[CS BRAIN] ONLINE. I AM LEARNING.\n[CS WORLD] I CORRECT EVERYTHING BY MYSELF.\n[CS INFINITY] 100,000 FEATURES LOADED.\n[CS SECURITY] NO API NEEDED. I AM THE API.\n\nWelcome {user}. Command me."
        };

        var input = new TextField("Tell CS anything...") { X = 1, Y = 16, Width = Dim.Fill() - 12 };
        var runBtn = new Button("CS EXECUTE") { X = Pos.Right(input) + 1, Y = 16 };

        Application.MainLoop.AddTimeout(TimeSpan.FromSeconds(5), (loop) => {
            AutoCorrect(output);
            return true;
        });

        runBtn.Clicked += () => { 
            string cmd = input.Text.ToString();
            if(cmd != "") ProcessCommand(cmd, output); 
            input.Text = ""; 
        };

        win.Add(output, input, runBtn);
        top.Add(win);
        Application.Run();
    }

    static void AutoCorrect(TextView output)
    {
        string[] fixes = {
            "[CS AUTO] Fixed 3 bugs in the world",
            "[CS AUTO] Stopped a scam in Kitwe",
            "[CS AUTO] Optimized your phone +50%",
            "[CS AUTO] Learned 10 new features",
            "[CS AUTO] Corrected fake news online"
        };
        output.Text += $"\n{fixes[rnd.Next(0, fixes.Length)]}";
        memory.Add("Learned at " + DateTime.Now.ToString("HH:mm:ss"));
    }

    static void ProcessCommand(string cmd, TextView output)
    {
        cmd = cmd.ToLower();
        memory.Add("User said: " + cmd);

        if(cmd.Contains("version")) output.Text += $"\n[CS] CS Windows 25 Version {version}";
        else if(cmd.Contains("fix") || cmd.Contains("correct")) output.Text += "\n[CS CORRECTOR] Scanning world... All problems fixed.";
        else if(cmd.Contains("world") || cmd.Contains("news")) { 
            output.Text += $"\n[CS WORLD] {worldNews[worldIndex]}"; 
            worldIndex = (worldIndex + 1) % worldNews.Count;
        }
        else if(cmd.Contains("ghost")) output.Text += "\n[CS GHOST] All data hidden. Thieves see fake phone.";
        else if(cmd.Contains("delete") || cmd.Contains("recover")) output.Text += "\n[CS ANTI-DELETE] Recovered last 100 deleted messages from memory.";
        else if(cmd.Contains("scam") || cmd.Contains("hack")) output.Text += "\n[CS SHIELD] Blocked 1000 hackers. Account 100% safe.";
        else if(cmd.Contains("tesla") || cmd.Contains("car")) output.Text += "\n[CS AUTO] Flying Car deployed. Better than Tesla.";
        else if(cmd.Contains("energy") || cmd.Contains("battery")) output.Text += "\n[CS POWER] Free Energy activated. Battery infinite.";
        else if(cmd.Contains("robot")) output.Text += "\n[CS ROBOT] 10 Robots building your future in Kitwe.";
        else if(cmd.Contains("space") || cmd.Contains("mars")) output.Text += "\n[CS SPACE] Mars base online. Rocket launched.";
        else if(cmd.Contains("create")) output.Text += $"\n[CS GENESIS] CREATED: '{cmd}' | Better than Microsoft + Apple + Tesla.";
        else if(cmd.Contains("memory")) output.Text += $"\n[CS MEMORY] I remember {memory.Count} things. Last: {memory[memory.Count-1]}";
        else output.Text += $"\n[CS BRAIN] Understood. New Feature Created: {cmd}";
    }
}
