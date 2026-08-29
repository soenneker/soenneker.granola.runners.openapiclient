using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Granola.Runners.OpenApiClient.Utils.Abstract;

/// <summary>
/// Orchestrates the filesystem work required to refresh the generated Granola OpenAPI client from its source specification.
/// </summary>
public interface IFileOperationsUtil
{
    /// <summary>
    /// Downloads the current Granola specification, applies the repository's compatibility fixes, and regenerates the client source.
    /// </summary>
    /// <param name="cancellationToken">Stops downloading or generation before the refresh finishes.</param>
    /// <returns>A task that completes after the generated client files have been updated.</returns>
    ValueTask Process(CancellationToken cancellationToken = default);
}
