namespace LuckySteps
{
    internal interface IUserCreator
    {
        void InputDatas(string userName);
        bool Validate();
        IUser CreateUser(string userName);
    }
}
