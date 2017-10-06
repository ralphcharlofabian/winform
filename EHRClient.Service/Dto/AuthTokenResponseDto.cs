namespace EHRClient.Service.Dto
{
    public class AuthTokenResponseDto
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }
}