using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <summary>
    /// AppyChat Post Statistics
    /// </summary>
    public class Stats
    {

        private long sharesField;

        private ReactionCounts reactionCountsField;

        /// <remarks/>
        public long Shares
        {
            get
            {
                return this.sharesField;
            }
            set
            {
                this.sharesField = value;
            }
        }

        /// <summary>
        /// Counts of likes, loves, etc
        /// </summary>
        public ReactionCounts ReactionCounts
        {
            get
            {
                return this.reactionCountsField;
            }
            set
            {
                this.reactionCountsField = value;
            }
        }
    }
}
