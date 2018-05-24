namespace TimeKeeper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"./times/";
            ITimeWriter writer = new FileTimeWriter(folderPath);
            IProgramAction action = new ProgramAction();

            string input;
            do
            {
                System.Console.Write("Waiting for input: ");
                input = System.Console.ReadLine();

            } while (action.PerformAction(input, writer));

            System.Console.WriteLine("Done");
            System.Console.Read();
        }
    }
}
