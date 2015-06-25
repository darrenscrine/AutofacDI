namespace Data
{
    public interface ILogger
    {
        string GetMessage();
        void Log(string message);
    }
}
