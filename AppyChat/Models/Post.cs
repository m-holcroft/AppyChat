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
        public string Author { get; set; }

        public DateTime Created { get; set; }

        /// <summary>
        /// AppyChat Post Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Media links for photos and videos
        /// </summary>
        public string Multimedia { get; set; }

        /// <summary>
        /// Post Statistics
        /// </summary>
        public Stats Stats { get; set; }

        /// <summary>
        /// Recipient comments
        /// </summary>
        public List<Comment> Comment { get; set; }

        /// <summary>
        /// List of recipient reactions
        /// </summary>
        public List<Reaction> Reaction { get; set; }
    }
}