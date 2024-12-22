using Soenneker.Stripe.Suite.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Stripe.Suite.Tests;

[Collection("Collection")]
public class DefaultTests : FixturedUnitTest
{
    private readonly IDefault _util;

    public DefaultTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IDefault>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
