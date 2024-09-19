
using System.Text.Json;

namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, string content ,HttpAction action = HttpAction.GET, bool formatJson = true);
        Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.GET, bool formatJson = true);
        bool IsUrlValid(string url);
    }
}