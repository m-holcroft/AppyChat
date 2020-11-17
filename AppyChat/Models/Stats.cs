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
        /// <summary>
        ///
        /// </summary>
        public long Shares { get; set; }

        /// <summary>
        /// Counts of likes, loves, etc
        /// </summary>
        public ReactionCounts ReactionCounts { get; set; }
    }
}