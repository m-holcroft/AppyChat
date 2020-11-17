namespace AppyChat.Models.DatabaseSettings
{
    public class AppyChatDatabaseSettings : IAppyChatDatabaseSettings
    {
        public string PostsCollectionName { get; set; }
        public string CommentsCollectionName { get; set; }
        public string ReactionsCollectionName { get; set; }
        public string RepliesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IAppyChatDatabaseSettings
    {
        string PostsCollectionName { get; set; }
        string CommentsCollectionName { get; set; }
        string ReactionsCollectionName { get; set; }
        string RepliesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}