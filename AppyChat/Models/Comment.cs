using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <summary>
    /// AppyChat Comment
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Date/Time comment added
        /// </summary>
        [BsonElement("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Author Id
        /// </summary>
        [BsonElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// Comment Text
        /// </summary>
        [BsonElement("text")]
        public string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [BsonElement("gifLink")]
        public string GIFLink { get; set; }

        /// <summary>
        /// Counts of likes, loves, etc
        /// </summary>
        public ReactionCounts ReactionCounts { get; set; }

        /// <summary>
        /// Direct reply to a comment
        /// </summary>
        public List<Reply> Reply { get; set; }

        /// <summary>
        /// List of recipient reactions
        /// </summary>
        public List<Reaction> Reaction { get; set; }
    }
}