using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace MobbingService
{
    [ServiceContract]
    public interface IMyRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "GetProductList/")]
        List<Product> GetProductList();
    } 
}
