using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DoorWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WcfService.svc or WcfService.svc.cs at the Solution Explorer and start debugging.
    public class WcfService : IWcfService
    {
        public List<AccessLog> AccessLogs()
        {
            return DataHelper.LogList();
        }

        public bool AddCard(Card composite)
        {
            return DataHelper.addCard(composite);
        }

        public bool DeleteCard(Card composite)
        {
            return DataHelper.DeleteCard(composite);
        }

        public bool AddDoor(Door composite)
        {
            return DataHelper.addDoor(composite);
        }

        public List<Door> DoorList()
        {
            return DataHelper.Doors();
        }

        public bool DeleteDoor(Door composite)
        {
            return DataHelper.DeleteDoor(composite);
        }

        public bool UpdateCard(EditCard composite)
        {
            return DataHelper.EditCard(composite);
        }

        public bool UpdateDoor(EditDoor composite)
        {
            return DataHelper.EditDoor(composite);
        }

        public List<Card> CardList()
        {
            return DataHelper.Cards();
        }

    }
}
