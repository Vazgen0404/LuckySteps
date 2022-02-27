namespace LuckySteps
{
    internal interface IGameCreator
    {
        IUser GetUser(string userName);
        ITicket CreateAndInitializeTicket();
        IGame CreateGame(string userName);
    }
}
