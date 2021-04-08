using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace CSharp9.Tests
{
    public class GenericTests
    {
        [Fact]
        public async Task CanCreateNewEvent()
        {
            var id = Guid.NewGuid();
            var parent = Guid.NewGuid();
            var version = 1;

            var @event = new ParentAssigned(id, parent, version + 1);

            @event.Id.Should().Be(id);
            @event.ParentId.Should().Be(parent);
            @event.Version.Should().Be(2);
        }
    }
}