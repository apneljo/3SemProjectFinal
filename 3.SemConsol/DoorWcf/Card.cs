using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoorWcf
{
    [DataContract]
    public class Card
    {
        private string _cardId;

        [DataMember]
        public string CardId
        {
            get { return _cardId; }
            set { _cardId = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Card))
            {
                return false;
            }
            else
            {
                Card CardObj = (Card)obj;
                if (CardId.Equals(CardObj.CardId) && _cardId.Equals(CardObj.CardId))
                {
                    return true;
                }
                return false;
            }
        }



    }
}