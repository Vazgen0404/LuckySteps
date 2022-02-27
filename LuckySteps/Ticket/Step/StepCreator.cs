using System;

namespace LuckySteps
{
    internal class StepCreator
    {
        public IStep CreateStep()
        {
            IColoumn left = new Column(Convert.ToBoolean(new Random().Next(0,2)));
            IColoumn right = new Column(!left.IsEmpty);

            return new Step(left, right);

        }
    }
}
