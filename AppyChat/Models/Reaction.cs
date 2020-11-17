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
        public DateTime Created { get; set; }

        /// <summary>
        /// Reaction made. See enumeration list
        /// </summary>
        public Enums.Reaction ReactionType { get; set; }

        /// <summary>
        /// Person who made the reaction
        /// </summary>
        public string ReactedBy { get; set; }

        public string Id { get; set; }
    }
}