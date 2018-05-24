namespace TimeKeeper.Console
{
    class ProgramAction : IProgramAction
    {
        public bool PerformAction(string input, ITimeWriter writer)
        {
            switch (input.ToLower())
            {
                case "start":
                    StartClock(writer);
                    break;
                case "end":
                    StopClock(writer);
                    return false;
                case "break-start":
                    StartBreak(writer);
                    break;
                case "break-end":
                    StopBreak(writer);
                    break;
                case "help":
                    Help();
                    break;
                default:
                    DefaultAction(input);
                    break;
            }
            return true;
        }

        private void StartClock(ITimeWriter writer)
        {
            writer.LogStart();
        }

        private void StopClock(ITimeWriter writer)
        {
            writer.LogStop();
        }

        private void StartBreak(ITimeWriter writer)
        {
            writer.LogBreakStart();
        }

        private void StopBreak(ITimeWriter writer)
        {
            writer.LogBreakStop();
        }

        private void Help()
        {
            System.Console.WriteLine("Valid Commands: ");
            System.Console.WriteLine("     start");
            System.Console.WriteLine("     end");
            System.Console.WriteLine("     break-start");
            System.Console.WriteLine("     break-end");
            System.Console.WriteLine("     help");
        }

        private void DefaultAction(string input)
        {
            System.Console.WriteLine("Invalid Command Entered: \"" + input + "\" for help type \"help\"");
        }
    }
}
