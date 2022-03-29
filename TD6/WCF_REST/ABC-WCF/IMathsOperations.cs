using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MathsLibrary
{
    [ServiceContract]
    public interface IMathsOperations
    {
        // GET methods

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Add?a={a}&b={b}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped , ResponseFormat = WebMessageFormat.Json)]
        int Add(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Multiply?a={a}&b={b}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int Multiply(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Substract?a={a}&b={b}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int Substract(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Divide?a={a}&b={b}", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        double Divide(int a, int b);

        // POST Methods

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Add", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int AddPost(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Substract", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int SubstractPost(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Multiply", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        int MultiplyPost(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Divide", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        double DividePost(int a, int b);
    }

}
