using System;
using FluentAssertions;
using NUnit.Framework;
using NzbDrone.Test.Common;

namespace NzbDrone.Windows.EnvironmentInfo
{
    [TestFixture]
    [Platform("Win")]
    public class DotNetRuntimeProviderFixture : TestBase<DotNetRuntimeProvider>
    {
        [Test]
        public void should_get_framework_version()
        {
            Subject.RuntimeVersion.Major.Should().Be(4);
            Subject.RuntimeVersion.Minor.Should().BeOneOf(0, 5, 6);
        }
    }
}
