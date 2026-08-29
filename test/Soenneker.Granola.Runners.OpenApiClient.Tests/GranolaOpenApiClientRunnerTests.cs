using Soenneker.Tests.HostedUnit;

namespace Soenneker.Granola.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GranolaOpenApiClientRunnerTests : HostedUnitTest
{
    public GranolaOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
