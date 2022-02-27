namespace LuckySteps
{
    internal interface IStep
    {
         IColoumn LeftColoumn { get;}
         IColoumn RightColoumn { get;}
         int Money { get; set; }
    }
}
