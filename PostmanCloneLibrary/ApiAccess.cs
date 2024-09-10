using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLibrary
{
    public class ApiAccess : IApiAccess
    {
        private readonly HttpClient httpClient = new();

        public async Task<string> CallApiAsync(string url,
                                               bool formatJson = true,
                                               HttpAction action = HttpAction.GET)
        {
            var apiResponse = await httpClient.GetAsync(url);

            if (apiResponse.IsSuccessStatusCode)
            {
                string json = await apiResponse.Content.ReadAsStringAsync();

                if (formatJson == true)
                {
                    var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);

                    json = JsonSerializer.Serialize(jsonElement, new JsonSerializerOptions { WriteIndented = true });

                }


                return json;

            }
            else
            {
                return $"Error: {apiResponse.StatusCode}";

            }

        }

        public bool IsUrlValid(string url)
        {
            if (string.IsNullOrWhiteSpace(url) == false)
            {
                return true;
            }


            bool output = Uri.TryCreate(url, UriKind.Absolute, out Uri? uriOutput) && (uriOutput.Scheme == Uri.UriSchemeHttps);

            return output;
        }
    }
}
