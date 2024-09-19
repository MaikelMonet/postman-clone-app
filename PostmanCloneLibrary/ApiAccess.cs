using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient httpClient = new();

        public async Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatJson = true)
        {

            StringContent stringContent = new(content, Encoding.UTF8, "application/json");

            return await CallApiAsync(url, stringContent, action, formatJson);
        }

        public async Task<string> CallApiAsync(string url, HttpContent? content = null ,HttpAction action = HttpAction.GET, bool formatJson = true)
        {
            HttpResponseMessage? apiResponse = null;

            switch (action)
            {
                case HttpAction.GET:
                    apiResponse = await httpClient.GetAsync(url);
                    break;
                case HttpAction.POST:
                    apiResponse = await httpClient.PostAsync(url, content);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(); 
                   
            }


            if (apiResponse!.IsSuccessStatusCode)
            {
               string response = await apiResponse.Content.ReadAsStringAsync();

                if (formatJson == true)
                {
                    JsonElement jsonElement = JsonSerializer.Deserialize<JsonElement>(response);

                    response = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

                }


                return response;

            }
            else
            {
                return $"Error: {apiResponse.StatusCode}";

            }

        }

        public bool IsUrlValid(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return false;
            }


            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);

            return output;
        }
    }
}
