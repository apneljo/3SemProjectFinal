using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoorWcf
{
    [DataContract]
    public class AccessLog
    {
        private int _doorId;
        private string _cardId;
        private string _dateTime;
        private string _access;

        [DataMember]
        public int DoorId
        {
            get { return _doorId; }
            set { _doorId = value; }
        }

        [DataMember]
        public string CardId
        {
            get { return _cardId; }
            set { _cardId = value; }
        }

        [DataMember]
        public string DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }

        [DataMember]
        public string Access
        {
            get { return _access; }
            set { _access = value; }
        }
    }
}