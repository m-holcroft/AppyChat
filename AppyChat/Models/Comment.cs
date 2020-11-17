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
        /// Unique Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Date/Time comment added
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Author Id
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Comment Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
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