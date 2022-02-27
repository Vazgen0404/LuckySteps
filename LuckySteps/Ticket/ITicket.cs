namespace LuckySteps
{
    internal interface ITicket
    {
        IStep[] Steps { get; }
        int LastStepNumber { get; set; }
    }
}
