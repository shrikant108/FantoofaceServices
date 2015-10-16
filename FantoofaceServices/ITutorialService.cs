using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace FantoofaceServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITutorialService" in both code and config file together.
    [ServiceContract]
    public interface ITutorialService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "/GetMenuDetails/?apikey=")]
        List<TutorialDataContract> GetTutorials(string apikey);
    }

    [DataContract]
    public class TutorialDataContract
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public string Categoryname { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string createdDate { get; set; }
    }
}
