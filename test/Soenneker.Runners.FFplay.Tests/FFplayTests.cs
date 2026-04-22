using Soenneker.Tests.HostedUnit;

namespace Soenneker.Runners.FFplay.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class FFplayTests : HostedUnitTest
{

    public FFplayTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
