using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SA46Team12BookShopApp.WCFServices
{
    [ServiceContract]
    interface IService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/WCFBook/{BookID}", ResponseFormat = WebMessageFormat.Json)]
        Book GetBook(string BookID);

        [OperationContract]
        [WebGet(UriTemplate = "/WCFBooks", ResponseFormat = WebMessageFormat.Json)]
        List<Book> GetBookList();

        [OperationContract]
        [WebGet(UriTemplate = "/WCFBookISBN/{ISBN}", ResponseFormat = WebMessageFormat.Json)]
        Book GetBookbyISBN(string ISBN);

        [OperationContract]
        [WebGet(UriTemplate = "/WCFUserOrders", ResponseFormat = WebMessageFormat.Json)]
        List<OrderHeader> GetUserOrders();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddOrder", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddOrder(OrderHeader o, List<OrderDetail> od);
    }

    

}
