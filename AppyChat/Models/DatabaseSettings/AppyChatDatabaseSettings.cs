namespace AppyChat.Models.DatabaseSettings
{
    public class AppyChatDatabaseSettings : IAppyChatDatabaseSettings
    {
        public string AppyChatCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAppyChatDatabaseSettings
    {
        string AppyChatCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}