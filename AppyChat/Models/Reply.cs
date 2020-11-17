using System;
using System.Collections.Generic;

namespace AppyChat.Models
{
    /// <summary>
    /// AppyChat Comment response
    /// </summary>
    public partial class Reply
    {
        /// <summary>
        /// Date/Time comment added
        /// </summary>
        public DateTime Created
        {
            get; set;
        }

        /// <summary>
        /// Author Id
        /// </summary>
        public string Author
        {
            get; set;
        }

        /// <summary>
        /// Comment Text
        /// </summary>
        public string Text
        {
            get; set;
        }

        public string GIFLink
        {
            get; set;
        }

        /// <summary>
        /// Counts of likes, loves, etc
        /// </summary>
        public ReactionCounts ReactionCounts
        {
            get; set;
        }

        /// <summary>
        /// List of recipient reactions
        /// </summary>
        public List<Reaction> Reactions
        {
            get; set;
        }
        public string Id { get; internal set; }
    }
}