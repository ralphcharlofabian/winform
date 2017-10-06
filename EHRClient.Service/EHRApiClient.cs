using System.Configuration;
using RestSharp;

namespace EHRClient.Service
{
    public class EHRApiClient : RestClient
    {
        public EHRApiClient()
            : base(ConfigurationManager.AppSettings["EHRUrlApi"])
        {
        }

        public override IRestResponse<T> Execute<T>(IRestRequest request)
        {
            request.AddHeader("Authorization", "bearer " + AuthToken.AccessToken);
            return base.Execute<T>(request);
        }
    }
}
