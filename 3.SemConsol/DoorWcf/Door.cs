using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoorWcf
{
    [DataContract]
    public class Door
    {
        private int _doorId;

        [DataMember]
        public int DoorId
        {
            get { return _doorId; }
            set { _doorId = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Door))
            {
                return false;
            }
            else
            {
                Door CardObj = (Door)obj;
                if (DoorId.Equals(CardObj.DoorId) && _doorId.Equals(CardObj.DoorId))
                {
                    return true;
                }
                return false;
            }
        }
    }
}