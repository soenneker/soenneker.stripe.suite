using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Stripe.Suite.Tests;

[Collection("Collection")]
public class StripeSuiteTests : FixturedUnitTest
{
    public StripeSuiteTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
