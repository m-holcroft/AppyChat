using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppyChat.Models
{
    public class Reaction
    {

        private System.DateTime createdField;

        private Enums.Reaction reaction1Field;

        private string reactedByField;

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
        /// Reaction made. See enumeration list
        /// </summary>
        public Enums.Reaction ReactionType
        {
            get
            {
                return this.reaction1Field;
            }
            set
            {
                this.reaction1Field = value;
            }
        }

        /// <summary>
        /// Person who made the reaction
        /// </summary>
        public string ReactedBy
        {
            get
            {
                return this.reactedByField;
            }
            set
            {
                this.reactedByField = value;
            }
        }
    }
}
