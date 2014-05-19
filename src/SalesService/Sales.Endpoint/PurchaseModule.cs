using Nancy;
using Nancy.ModelBinding;
using Raven.Client.Document;

namespace Sales.Endpoint
{
    public class PurchaseModule : NancyModule
    {
        public PurchaseModule()
        {
            Post["/Purchase"] = parameters =>
                {
                    var purchaseOrder = this.Bind<PurchaseOrder>();
                    var store = new DocumentStore { Url = "http://localhost:8080", DefaultDatabase = "SalesDB" }.Initialize();
                    using (var session = store.OpenSession())
                    {
                        session.Store(purchaseOrder);
                        session.SaveChanges();
                    }

                    return "Purchased";
                }; 
        }
    }

}