using AppyChat.Models;
using AppyChat.Models.DatabaseSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Repositories
{
    public class ReactionRepository
    {
        private readonly IMongoCollection<Reaction> _reactions;

        public ReactionRepository(IAppyChatDatabaseSettings appyChatDatabaseSettings_)
        {
            var client = new MongoClient(appyChatDatabaseSettings_.ConnectionString);
            var database = client.GetDatabase(appyChatDatabaseSettings_.DatabaseName);

            _reactions = database.GetCollection<Reaction>(appyChatDatabaseSettings_.ReactionsCollectionName);
        }

        public List<Reaction> Get()
        {
            return _reactions.Find(r => true).ToList();
        }

        public Reaction Get(string id)
        {
            return _reactions.Find<Reaction>(r => r.Id == id).FirstOrDefault();
        }

        public Reaction Create(Reaction reaction)
        {
            _reactions.InsertOne(reaction);
            return reaction;
        }

        public void Update(string id, Reaction reaction)
        {
            _reactions.ReplaceOne(r => r.Id == id, reaction);
        }

        public void Remove(Reaction reactionIn)
        {
            _reactions.DeleteOne(reaction => reaction.Id == reactionIn.Id);
        }

        public void Remove(string id)
        {
            _reactions.DeleteOne(reaction => reaction.Id == id);
        }
    }
}