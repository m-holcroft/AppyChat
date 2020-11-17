using AppyChat.Models;
using AppyChat.Models.DatabaseSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Repositories
{
    public class AppyChatRepository
    {
        private readonly IMongoCollection<Post> _posts;

        public AppyChatRepository(IAppyChatDatabaseSettings appyChatDatabaseSettings_)
        {
            var client = new MongoClient(appyChatDatabaseSettings_.ConnectionString);
            var database = client.GetDatabase(appyChatDatabaseSettings_.DatabaseName);

            _posts = database.GetCollection<Post>(appyChatDatabaseSettings_.AppyChatCollectionName);
        }

        public List<Post> Get()
        {
            return _posts.Find(p => true).ToList();
        }

        public Post Get(string id)
        {
            return _posts.Find<Post>(p => p.Id == id).FirstOrDefault();
        }

        public Post Create(Post post)
        {
            _posts.InsertOne(post);
            return post;
        }

        public void Update(string id, Post post)
        {
            _posts.ReplaceOne(p => p.Id == id, post);
        }

        public void Remove(Post postIn)
        {
            _posts.DeleteOne(post => post.Id == postIn.Id);
        }

        public void Remove(string id)
        {
            _posts.DeleteOne(post => post.Id == id);
        }

        public List<Reaction> GetPostReactions(string postId)
        {
            var reactions = new List<Reaction>();
            var post = _posts.Find(p => p.Id == postId).FirstOrDefault();

            if (post != null)
            {
                reactions = post.Reactions;
            }

            return reactions;
        }

        public List<Comment> GetPostComments(string postId)
        {
            var comments = new List<Comment>();
            var post = _posts.Find(p => p.Id == postId).FirstOrDefault();

            if (post != null)
            {
                comments = post.Comments;
            }

            return comments;
        }
    }
}