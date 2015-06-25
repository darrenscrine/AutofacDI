namespace Data
{
    public interface IRepository
    {
        void Clear();
        void Load();
        void Save();
        string ToString();
        string GetMessage();
    }
}
