using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <summary>
    /// AppyChat Post and Comment reaction counts
    /// </summary>
    public class ReactionCounts
    {
        [BsonElement("angry")]
        public long Angry { get; set; }

        public long Awesome { get; set; }
        public long Boring { get; set; }
        public long Care { get; set; }
        public long Crazy { get; set; }
        public long FakeNews { get; set; }
        public long Haha { get; set; }
        public long Lame { get; set; }
        public long Legal { get; set; }
        public long Like { get; set; }
        public long Love { get; set; }
        public long Meal { get; set; }
        public long Sad { get; set; }
        public long Scary { get; set; }
        public long Wow { get; set; }
    }
}