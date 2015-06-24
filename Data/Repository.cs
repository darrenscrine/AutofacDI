namespace Data
{
    public class Repository : IRepository
    {
        public ILogger Logger { get; set; }

        public Repository(ILogger logger)
        {
            Logger = logger;
        }

        public void Load()
        {
            Logger.Log("Called from load");
        }

        public void Save()
        {
            Logger.Log("Called from Save");
        }

        public void Clear()
        {
            Logger.Log("Called from Clear");
        }
    }
}
