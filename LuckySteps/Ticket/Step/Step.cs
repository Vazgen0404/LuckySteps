namespace LuckySteps
{
    internal class Step : IStep
    {
        public IColoumn LeftColoumn { get; }

        public IColoumn RightColoumn { get; }
        public int Money { get; set; }
        public Step(IColoumn left, IColoumn right)
        {
            LeftColoumn = left;
            RightColoumn = right;
        }
    }
}
