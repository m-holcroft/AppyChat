using AppyChat.Models;
using AppyChat.Models.DatabaseSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Repositories
{
    public class RepliesRepository
    {
        private readonly IMongoCollection<Reply> _replies;

        public RepliesRepository(IAppyChatDatabaseSettings appyChatDatabaseSettings_)
        {
            var client = new MongoClient(appyChatDatabaseSettings_.ConnectionString);
            var database = client.GetDatabase(appyChatDatabaseSettings_.DatabaseName);

            _replies = database.GetCollection<Reply>(appyChatDatabaseSettings_.RepliesCollectionName);
        }

        public List<Reply> Get()
        {
            return _replies.Find(r => true).ToList();
        }

        public Reply Get(string id)
        {
            return _replies.Find<Reply>(r => r.Id == id).FirstOrDefault();
        }

        public Reply Create(Reply reply)
        {
            _replies.InsertOne(reply);
            return reply;
        }

        public void Update(string id, Reply reply)
        {
            _replies.ReplaceOne(r => r.Id == id, reply);
        }

        public void Remove(Reply replyIn)
        {
            _replies.DeleteOne(reply => reply.Id == replyIn.Id);
        }

        public void Remove(string id)
        {
            _replies.DeleteOne(reply => reply.Id == id);
        }
    }
}