using System;
using System.Collections.Generic;
using System.IO;
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
        [WebGet(UriTemplate = "/Book/{BookID}", ResponseFormat = WebMessageFormat.Json)]
        Book GetBook(string BookID);


        [OperationContract]
        [WebGet(UriTemplate = "/BookImage/{BookID}", RequestFormat = WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Bare)]
        Stream GetImage(string BookID);

        [OperationContract]
        [WebGet(UriTemplate = "/Category/{CategoryID}", ResponseFormat = WebMessageFormat.Json)]
        Category GetCategory(string CategoryID);


        [OperationContract]
        [WebGet(UriTemplate = "/Books", ResponseFormat = WebMessageFormat.Json)]
        List<Book> GetBookList();


        [OperationContract]
        [WebGet(UriTemplate = "/Categories", ResponseFormat = WebMessageFormat.Json)]
        List<Category> GetCategoryList();

        [OperationContract]
        [WebGet(UriTemplate = "/BookISBN/{ISBN}", ResponseFormat = WebMessageFormat.Json)]
        Book GetBookbyISBN(string ISBN);

        [OperationContract]
        [WebGet(UriTemplate = "/UserOrders", ResponseFormat = WebMessageFormat.Json)]
        List<OrderHeader> GetUserOrders();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AddOrder", Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
            RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddOrder(OrderHeader o, List<OrderDetail> od);




        [OperationContract]
        [WebInvoke(UriTemplate = "/Update", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Book UpdateBook(Book b);
    }

    

}
