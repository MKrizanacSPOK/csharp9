using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace CSharp9.Tests
{
    public class SerializationTests
    {
        [Fact]
        public async Task CanSerialize()
        {
            var product = new Product { Id = 1, Name = "test"};

            var result = JsonSerializer.Serialize(product);

            result.Should().Contain("Id");
        }

        [Fact]
        public async Task CanDeserialize()
        {
            var json = "{ \"Id\": 1, \"Name\": \"test\" }";

            var result = JsonSerializer.Deserialize<Product>(json);

            result.Id.Should().Be(1);
            result.Name.Should().Be("test");
        }

        [Fact]
        public async Task CanCloneWithNewProperty()
        {
            var product = new Product { Id = 1, Name = "test"};

            var result = product with {Name = "tested with clone"};

            result.Id.Should().Be(1);
            result.Name.Should().Be("tested with clone");

            product.Id.Should().Be(1);
            product.Name.Should().Be("test");
        }
    }
}