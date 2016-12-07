using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DoorWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfService" in both code and config file together.
    [ServiceContract]
    public interface IWcfService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "GetCardList/")]
        List<Card> CardList();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "GetLogList/")]
        List<AccessLog> AccessLogs();

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "AddCard/")]
        bool AddCard(Card composite);

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "DeleteCard/")]
        bool DeleteCard(Card composite);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "AddDoor/")]
        bool AddDoor(Door composite);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "GetDoorList/")]
        List<Door> DoorList();

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "DeleteDoor/")]
        bool DeleteDoor(Door composite);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "EditCard/")]
        bool UpdateCard(EditCard composite);

        [OperationContract]
        [WebInvoke(Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "EditDoor/")]
        bool UpdateDoor(EditDoor composite);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "GetLogByDoor/{dooriD}")]
        List<AccessLog> LogbyDoor(string dooriD);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "GetLogByCard/{cardiD}")]
        List<AccessLog> LogbyCard(string cardiD);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "AddDoorAccess/")]
        bool AddDoorAccess(DoorAccess composite);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "GetAccessList/")]
        List<DoorAccess> Accesslist();

        [OperationContract]
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "DeleteDoorAccess/")]
        bool DeleteDoorAccess(DoorAccess composite);
    }
}
