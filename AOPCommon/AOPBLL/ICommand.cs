namespace AOPCommon.AOPBLL
{
    public interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}