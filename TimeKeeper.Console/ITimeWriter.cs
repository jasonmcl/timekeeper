namespace TimeKeeper.Console
{
    interface ITimeWriter
    {
        void LogStart();
        void LogStop();
        void LogBreakStart();
        void LogBreakStop();
    }
}
