
namespace PostmanCloneLibrary
{
    public interface IApiAccess
    {
        Task<string> CallApiAsync(string url, bool formatJson = true, HttpAction action = HttpAction.GET);
        bool IsUrlValid(string url);
    }
}