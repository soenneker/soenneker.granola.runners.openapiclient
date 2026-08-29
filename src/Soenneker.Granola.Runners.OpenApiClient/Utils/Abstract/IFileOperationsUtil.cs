using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Granola.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    /// <summary>
    /// Downloads, fixes, and generates the Granola OpenAPI client.
    /// </summary>
    ValueTask Process(CancellationToken cancellationToken = default);
}
