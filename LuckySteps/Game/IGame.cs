namespace LuckySteps
{
    internal interface IGame
    {
        IUser User { get; set; }
        ITicket Ticket { get; set; }
        int Money { get; set; }
        void Start();
    }
}
