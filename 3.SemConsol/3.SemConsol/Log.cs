using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SemConsol
{
    public class Log
    {
        public DateTime DateTime { get; set; }
        public int DoorID { get; set; }
        public string CardID { get; set; }
        public string AccesGranted { get; set; }

        public Log(DateTime dateTime, int doorId, string cardId, string accesGranted)
        {
            DateTime = dateTime;
            DoorID = doorId;
            CardID = cardId;
            AccesGranted = accesGranted;
        }

        public Log()
        {

        }

        public override string ToString()
        {
            return $"DateTime: {DateTime}, DoorID: {DoorID}, CardID: {CardID}, AccesGranted: {AccesGranted}";
        }
    }
}
