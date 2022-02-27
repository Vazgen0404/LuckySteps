namespace LuckySteps
{
    internal class Column : IColoumn
    {
        public bool IsEmpty { get; }
        public Column(bool isEmpty)
        {
            IsEmpty = isEmpty;
        }
    }
}
