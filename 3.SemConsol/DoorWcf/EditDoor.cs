using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoorWcf
{
    [DataContract]
    public class EditDoor
    {
        private int _oldDoornr;
        private int _newDoornr;

        [DataMember]
        public int OldDoornr
        {
            get { return _oldDoornr; }
            set { _oldDoornr = value; }
        }

        [DataMember]
        public int NewDoornr
        {
            get { return _newDoornr; }
            set { _newDoornr = value; }
        }
    }
}