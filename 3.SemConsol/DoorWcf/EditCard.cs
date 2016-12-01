using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoorWcf
{
    [DataContract]
    public class EditCard
    {
        private string _oldCardnr;
        private string _newCardnr;

        [DataMember]
        public string OldCardnr
        {
            get { return _oldCardnr; }
            set { _oldCardnr = value; }
        }

        [DataMember]
        public string NewCardnr
        {
            get { return _newCardnr; }
            set { _newCardnr = value; }
        }
    }
}