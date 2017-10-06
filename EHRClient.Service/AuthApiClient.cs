using System.Configuration;
using System.Net;
using EHRClient.Service.Dto;
using RestSharp;

namespace EHRClient.Service
{
    public class AuthApiClient: RestClient, IAuthApiClient
    {
        private readonly RestClient _authClient;

        public AuthApiClient()
        {
            _authClient = new RestClient(ConfigurationManager.AppSettings["AuthUrlApi"]);
        }

        public AuthTokenDto GetToken()
        {
            var request = new RestRequest("/token", Method.POST);
            request.AddParameter("grant_type", "client_credentials");
            request.AddParameter("client_id", ConfigurationManager.AppSettings["AuthClientId"]);
            request.AddParameter("client_secret", ConfigurationManager.AppSettings["AuthClientSecret"]);

            var response = _authClient.Execute<AuthTokenResponseDto>(request);

            if (response.StatusCode != HttpStatusCode.OK) return null;

            AuthToken.AccessToken = response.Data.access_token;
            AuthToken.RefreshToken = response.Data.refresh_token;

            return new AuthTokenDto
            {
                AccessToken = AuthToken.AccessToken,
                RefreshToken = AuthToken.RefreshToken
            };
        }
    }

    public interface IAuthApiClient
    {
        AuthTokenDto GetToken();
    }
}
