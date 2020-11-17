using AppyChat.Models;
using AppyChat.Models.DatabaseSettings;
using AppyChat.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppyChat.Tests
{
    [TestFixture]
    internal class PostRepositoryTests
    {
        private AppyChatRepository postRepository_;
        private IAppyChatDatabaseSettings appyChatDatabaseSettings_;

        [SetUp]
        public void Setup()
        {
            appyChatDatabaseSettings_ = new AppyChatDatabaseSettings() { ConnectionString = "mongodb://localhost:27017", DatabaseName = "AppyChatDb", AppyChatCollectionName= "Posts" };
            postRepository_ = new AppyChatRepository(appyChatDatabaseSettings_);
        }

        [Test]
        public void PostRepositoryReturnsCollection()
        {
            //  Setup
            var client = new MongoClient(appyChatDatabaseSettings_.ConnectionString);
            var database = client.GetDatabase(appyChatDatabaseSettings_.DatabaseName);

            //  Execute Tests
            var collection = database.GetCollection<Post>(appyChatDatabaseSettings_.AppyChatCollectionName);

            //  Assert Results
            Assert.IsNotNull(collection);
        }

        [Test]
        public void PostRepositoryGetsAllPosts()
        {
            //  Setup

            //  Execute Tests
            var posts = postRepository_.Get();

            //  Assert Results
            Assert.IsNotNull(posts);
        }

        [Test]
        public void PostRepositoryGetsSpecificPost()
        {
            //  Setup
            string testPostID = "5f85bd04f1bb5900d228cefb";

            //  Execute Tests
            var post = postRepository_.Get("5f85bd04f1bb5900d228cefb");

            //  Assert Results
            Assert.IsNotNull(post);
            Assert.AreEqual(post.Id, testPostID);
        }

        [Test]
        public void PostRepositoryInsertsTest()
        {
            //  Setup
            Post testPost = new Post() { Id = ObjectId.GenerateNewId().ToString(), Text = "UnitTestGeneratedPost" };
            
            //  Execute Tests
            postRepository_.Create(testPost);
            Post insertedPost = postRepository_.Get(testPost.Id);

            //  Assert Results
            Assert.IsNotNull(insertedPost);
            Assert.AreEqual(insertedPost.Id, testPost.Id);
            Assert.AreEqual(insertedPost.Text, testPost.Text);
        }
    }
    
}
