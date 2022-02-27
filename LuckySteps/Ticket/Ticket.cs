namespace LuckySteps
{
    internal class Ticket : ITicket
    {
        public IStep[] Steps { get; set; }
        public int LastStepNumber { get; set; }
        public Ticket()
        {
            Steps = new IStep[10];
        }
    }
}
