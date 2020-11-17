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

        private long angryField;

        private long awesomeField;

        private long boringField;


        private long careField;

        private long crazyField;

        private long fakeNewsField;

        private long hahaField;

        private long lameField;

        private long legalField;

        private long likeField;

        private long loveField;

        private long mealField;

        private long sadField;

        private long scaryField;

        private long wowField;

        /// <remarks/>
        public long Angry
        {
            get
            {
                return this.angryField;
            }
            set
            {
                this.angryField = value;
            }
        }

        /// <remarks/>
        public long Awesome
        {
            get
            {
                return this.awesomeField;
            }
            set
            {
                this.awesomeField = value;
            }
        }

        /// <remarks/>
        public long Boring
        {
            get
            {
                return this.boringField;
            }
            set
            {
                this.boringField = value;
            }
        }

        /// <remarks/>
        public long Care
        {
            get
            {
                return this.careField;
            }
            set
            {
                this.careField = value;
            }
        }

        /// <remarks/>
        public long Crazy
        {
            get
            {
                return this.crazyField;
            }
            set
            {
                this.crazyField = value;
            }
        }

        /// <remarks/>
        public long FakeNews
        {
            get
            {
                return this.fakeNewsField;
            }
            set
            {
                this.fakeNewsField = value;
            }
        }

        /// <remarks/>
        public long Haha
        {
            get
            {
                return this.hahaField;
            }
            set
            {
                this.hahaField = value;
            }
        }

        /// <remarks/>
        public long Lame
        {
            get
            {
                return this.lameField;
            }
            set
            {
                this.lameField = value;
            }
        }

        /// <remarks/>
        public long Legal
        {
            get
            {
                return this.legalField;
            }
            set
            {
                this.legalField = value;
            }
        }

        /// <remarks/>
        public long Like
        {
            get
            {
                return this.likeField;
            }
            set
            {
                this.likeField = value;
            }
        }

        /// <remarks/>
        public long Love
        {
            get
            {
                return this.loveField;
            }
            set
            {
                this.loveField = value;
            }
        }

        /// <remarks/>
        public long Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        public long Sad
        {
            get
            {
                return this.sadField;
            }
            set
            {
                this.sadField = value;
            }
        }

        /// <remarks/>
        public long Scary
        {
            get
            {
                return this.scaryField;
            }
            set
            {
                this.scaryField = value;
            }
        }

        /// <remarks/>
        public long Wow
        {
            get
            {
                return this.wowField;
            }
            set
            {
                this.wowField = value;
            }
        }
    }
}
