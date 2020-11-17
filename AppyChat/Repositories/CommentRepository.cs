using AppyChat.Models;
using AppyChat.Models.DatabaseSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Repositories
{
    public class CommentRepository
    {
        private readonly IMongoCollection<Comment> _comments;

        public CommentRepository(IAppyChatDatabaseSettings appyChatDatabaseSettings_)
        {
            var client = new MongoClient(appyChatDatabaseSettings_.ConnectionString);
            var database = client.GetDatabase(appyChatDatabaseSettings_.DatabaseName);

            _comments = database.GetCollection<Comment>(appyChatDatabaseSettings_.CommentsCollectionName);
        }

        public List<Comment> Get()
        {
            return _comments.Find(c => true).ToList();
        }

        public Comment Get(string id)
        {
            return _comments.Find<Comment>(c => c.Id == id).FirstOrDefault();
        }

        public Comment Create(Comment comment)
        {
            _comments.InsertOne(comment);
            return comment;
        }

        public void Update(string id, Comment comment)
        {
            _comments.ReplaceOne(c => c.Id == id, comment);
        }

        public void Remove(Comment commentIn)
        {
            _comments.DeleteOne(comment => comment.Id == commentIn.Id);
        }

        public void Remove(string id)
        {
            _comments.DeleteOne(comment => comment.Id == id);
        }
    }
}