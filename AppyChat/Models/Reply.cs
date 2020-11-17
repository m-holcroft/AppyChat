using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <summary>
    /// AppyChat Comment response
    /// </summary>
    public partial class Reply
    {

        private System.DateTime createdField;

        private string authorField;

        private string textField;

        private string gIFLinkField;

        private ReactionCounts reactionCountsField;

        private List<Reaction> reactionField;

        /// <summary>
        /// Date/Time comment added
        /// </summary>
        public System.DateTime Created
        {
            get
            {
                return this.createdField;
            }
            set
            {
                this.createdField = value;
            }
        }

        /// <summary>
        /// Author Id
        /// </summary>
        public string Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <summary>
        /// Comment Text
        /// </summary>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        public string GIFLink
        {
            get
            {
                return this.gIFLinkField;
            }
            set
            {
                this.gIFLinkField = value;
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

        /// <summary>
        /// List of recipient reactions
        /// </summary>
        public List<Reaction> Reactions
        {
            get
            {
                return this.reactionField;
            }
            set
            {
                this.reactionField = value;
            }
        }
    }
}
