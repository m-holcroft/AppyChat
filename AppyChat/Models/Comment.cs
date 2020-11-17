using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Comment
    {

        private System.DateTime createdField;

        private string authorField;

        private string textField;

        private string gIFLinkField;

        private ReactionCounts reactionCountsField;

        private Reply[] replyField;

        private Reaction[] reactionField;

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reply")]
        public Reply[] Reply
        {
            get
            {
                return this.replyField;
            }
            set
            {
                this.replyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reaction")]
        public Reaction[] Reaction
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
