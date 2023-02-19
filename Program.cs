using Newtonsoft.Json;

namespace BotwNameConverter;

internal static class Program
{
    private static IDictionary<string, string> _names = null!;

    private static void Main()
    {
        WriteAsciiArt();
        LoadNames();

        // Check if the converted folder exists.
        if(Directory.Exists("converted"))
        {
            // Clear the converted folder.
            Directory.Delete("converted", true);
        }
            
        // Create the new converter folder.
        Directory.CreateDirectory("converted");

        if (!Directory.Exists("files"))
        {
            Console.WriteLine("files directory does not exists. Press any key to close application...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        // Get all the files from the files folder and rename them.
        foreach(var file in Directory.GetFiles("files"))
        {
            var fileName = Path.GetFileName(file);
            var fileExt = Path.GetExtension(file);
            var jsonKey = fileName.Replace(fileName, GetNameValue(fileName.Replace(".png", ""), fileName));
            var newFileName = jsonKey + fileExt;
                
            File.Copy($"files/{fileName}", $"converted/{newFileName}", true);

            Console.WriteLine($"Renamed {fileName} to {newFileName}");
        }
            
        Console.WriteLine();
        Console.WriteLine("BotwNameConverter is finished. Press any key to close application...");
        Console.ReadKey();
    }

    private static void LoadNames()
    {
        // Check if the names.json file exists.
        if (!File.Exists("names.json"))
        {
            Console.WriteLine("File (names.json) does not exists. Press any key to close application...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        // Store all json variables in the _names.
        _names = JsonConvert.DeserializeObject<IDictionary<string, string>>(File.ReadAllText("names.json"))!;
    }

    private static void WriteAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(@" ____        _              _   _                         _____                          _            ");
        Console.WriteLine(@"|  _ \      | |            | \ | |                       / ____|                        | |           ");
        Console.WriteLine(@"| |_) | ___ | |___      __ |  \| | __ _ _ __ ___   ___  | |     ___  _ ____   _____ _ __| |_ ___ _ __ ");
        Console.WriteLine(@"|  _ < / _ \| __\ \ /\ / / | . ` |/ _` | '_ ` _ \ / _ \ | |    / _ \| '_ \ \ / / _ \ '__| __/ _ \ '__|");
        Console.WriteLine(@"| |_) | (_) | |_ \ V  V /  | |\  | (_| | | | | | |  __/ | |___| (_) | | | \ V /  __/ |  | ||  __/ |   ");
        Console.WriteLine(@"|____/ \___/ \__| \_/\_/   |_| \_|\__,_|_| |_| |_|\___|  \_____\___/|_| |_|\_/ \___|_|   \__\___|_|   ");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("BotwNameConverter version: v1.0");
        Console.WriteLine("Created by Almighty-Shogun");
        Console.WriteLine("GitHub: https://github.com/Almighty-Shogun/botw-name-converter");
        Console.WriteLine();
    }
        
    private static string GetNameValue(string key, string fallback = "") => _names.TryGetValue(key, out var value) ? value : fallback;
}