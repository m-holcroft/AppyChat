using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <summary>
    /// AppyChat Post Reaction
    /// </summary>
    public class Reaction
    {
        /// <summary>
        /// Date/Time comment added
        /// </summary>
        ///
        [BsonElement("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Reaction made. See enumeration list
        /// </summary>
        ///
        [BsonElement("reactionType")]
        public Enums.Reaction ReactionType { get; set; }

        /// <summary>
        /// Person who made the reaction
        /// </summary>
        ///
        [BsonElement("reactedBy")]
        public string ReactedBy { get; set; }
    }
}