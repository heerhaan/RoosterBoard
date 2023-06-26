using System.Net.Http.Headers;
using System.Text.Json;

namespace RoosterBoard.Data
{
    public class SpaceClient
    {
        private const string BaseUrl = "https://api.spacetraders.io/v2/";
        private const string BearerHttpHeader = "bearer";

        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _serializerOptions;

        public SpaceClient(HttpClient client)
        {
            _client = client;
            _client.BaseAddress = new Uri(BaseUrl);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            _serializerOptions = new JsonSerializerOptions();
        }

        public void RegisterAgent(string spacerName, string faction)
        {
            var path = "register";
        }

        private void SetToken(string spacerToken)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerHttpHeader, spacerToken);
        }
    }
}
