using System.Diagnostics;

namespace StartExeWithWorkdirAndOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            args = new string[] { @"P:\PangoC\Raylib\raylibTest.exe" };
#endif
            // Exit if no file is given or too many parameters.
            if (args.Length != 1)
            {
                Console.WriteLine("Cant work with this parameters! Give only one parameter with the full file path.");
                return;
            }

            // Exit if file does not exists.
            if (!File.Exists(args[0]))
            {
                Console.WriteLine($"File: '{args[0]}' does not exists!");
                return;
            }

            var path = args[0];
            var dir = Path.GetDirectoryName(path);
            var procInfo = new ProcessStartInfo(args[0]);
            procInfo.WorkingDirectory = dir;
            procInfo.RedirectStandardOutput = true;

            try
            {
                var process = Process.Start(procInfo);
                while (!process.StandardOutput.EndOfStream)
                {
                    Console.WriteLine(process.StandardOutput.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
