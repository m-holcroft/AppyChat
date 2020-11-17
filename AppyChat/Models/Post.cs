using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <summary>
    /// Appychat Post construct
    /// </summary>
    public partial class Post
    {
        /// <summary>
        /// Unique Id
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Author Id
        /// </summary>
        ///
        [BsonElement("author")]
        public string Author { get; set; }

        public DateTime Created { get; set; }

        /// <summary>
        /// AppyChat Post Text
        /// </summary>
        [BsonElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// Media links for photos and videos
        /// </summary>
        ///
        [BsonElement("multimedia")]
        public string Multimedia { get; set; }

        /// <summary>
        /// Post Statistics
        /// </summary>
        [BsonElement("stats")]
        public Stats Stats { get; set; }

        /// <summary>
        /// Recipient comments
        /// </summary>
        ///
        [BsonElement("comments")]
        public List<Comment> Comments { get; set; }

        /// <summary>
        /// List of recipient reactions
        /// </summary>
        [BsonElement("reactions")]
        public List<Reaction> Reactions { get; set; }
    }
}