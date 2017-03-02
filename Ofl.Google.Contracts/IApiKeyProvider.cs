using System.Threading;
using System.Threading.Tasks;

namespace Ofl.Google
{
    public interface IApiKeyProvider
    {
        Task<string> GetApiKeyAsync(CancellationToken cancellationToken);
    }
}
