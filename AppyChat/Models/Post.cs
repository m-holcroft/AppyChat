using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Post
    {

        private string idField;

        private string authorField;

        private System.DateTime createdField;

        private string textField;

        private string[] multimediaField;

        private string[] distributionField;

        private Stats statsField;

        private Comment[] commentField;

        private Reaction[] reactionField;

        /// <remarks/>

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
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

        [BsonElement("text")]
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
        [System.Xml.Serialization.XmlElementAttribute("Multimedia")]
        public string[] Multimedia
        {
            get
            {
                return this.multimediaField;
            }
            set
            {
                this.multimediaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public string[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        public Stats Stats
        {
            get
            {
                return this.statsField;
            }
            set
            {
                this.statsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comment")]
        public Comment[] Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
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
