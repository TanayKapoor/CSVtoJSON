using CsvToJsonLib;

namespace CsvToJsonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            void start()
            {
                Console.WriteLine("\n============\nWelcome! (>_<)\n============\n");
                Console.WriteLine("Enter the path for the CSV File -");
                string FP = Console.ReadLine();
                string FilePath =  $@"{FP}";
                Processor.ProcessLines(FilePath);
            }

            void restart()
            {
                Console.WriteLine("Press any key to restart...");
                Console.ReadKey();
                Console.Clear();
                start();
            }
            try
            {
                start();
            }
            catch (Exception e)
            {
                Console.WriteLine("File does not exits! Perhaps you might have put wrong filename or don't have extension included!");
                restart();
            }

        }
    }
}