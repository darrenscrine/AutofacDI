namespace Data
{
    public class Repository : IRepository
    {
        private ILogger Logger { get; set; }
        private string _message;

        public Repository(ILogger logger)
        {
            Logger = logger;
        }

        public void Load()
        {
            _message = "Called from load";
            Logger.Log(_message);
        }

        public void Save()
        {
            _message = "Called from save";
            Logger.Log(_message);
        }

        public string GetMessage()
        {
            return _message;
        }

        public void Clear()
        {
            _message = "Called from clear";
            Logger.Log(_message);
        }
    }
}
