using System.Collections.Generic;

namespace MobbingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IMyRestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IMyRestService.svc or IMyRestService.svc.cs at the Solution Explorer and start debugging.
    public class MyRestService : IMyRestService
    {
        public List<Product> GetProductList()
        {
            return Products.Instance.ProductList;
        }
    }
}
