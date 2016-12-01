using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoorWcf
{
    [DataContract]
    public class DoorAccess
    {
        private int _doorId;
        private string _cardId;

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
    }
}