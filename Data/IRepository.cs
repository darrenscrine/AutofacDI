namespace Data
{
    public interface IRepository
    {
        void Clear();
        void Load();
        ILogger Logger { get; set; }
        void Save();
    }
}
