using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DoorWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddCard(Card composite);

        [OperationContract]
        void AddDoor(Door composite);

        [OperationContract]
        void EditCard(EditCard composite);

        [OperationContract]
        void EditDoor(EditDoor composite);

        [OperationContract]
        void DeleteCard(Card composite);

        [OperationContract]
        void DeleteDoor(Door composite);

        [OperationContract]
        void AddDoorAccess(DoorAccess composite);

        [OperationContract]
        void DeleteDoorAccess(DoorAccess composite);

        [OperationContract]
        List<Card> GetCards();

        [OperationContract]
        List<Door> GetDoors();

        [OperationContract]
        List<DoorAccess> AccessList();

        [OperationContract]
        List<AccessLog> LogList();

        [OperationContract]
        List<AccessLog> LogListOnCardId(string CardID);

        [OperationContract]
        List<AccessLog> LogListOnDoorId(string DoorID);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    

   

    

   

   

    
}
