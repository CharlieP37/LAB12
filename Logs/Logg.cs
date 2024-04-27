using System;
using System.IO;

namespace LAB12.Logs
{
    public class Logg
    {
        private static readonly string logFilePath = "Logs/log.txt"; 

        public static void Log(string message)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now} - {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de log: {ex.Message}");
            }
        }
    }
}
