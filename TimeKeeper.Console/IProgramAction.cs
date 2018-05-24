namespace TimeKeeper.Console
{
    interface IProgramAction
    {
        bool PerformAction(string input, ITimeWriter writer);
    }
}
