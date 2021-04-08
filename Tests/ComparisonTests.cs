using FluentAssertions;
using Xunit;

namespace CSharp9.Tests
{
    public class ComparisonTests
    {
        [Fact]
        public void CanCompareRecords()
        {
            var record1 = new Product {Id = 1, Name = "test"};
            var record2 = record1 with {Name = "test2"};
            var record3 = record1 with {Name = null};
            var record4 = new Product {Id = 1, Name = "test"};

            record1.Equals(record2).Should().BeFalse();
            record2.Equals(record1).Should().BeFalse();

            record1.Equals(record3).Should().BeFalse();
            record3.Equals(record1).Should().BeFalse();

            record1.Equals(record4).Should().BeTrue(); // False for classes
            record4.Equals(record1).Should().BeTrue(); // False for classes
        }

        [Fact]
        public void CanCompareClasses()
        {
            var record1 = new Person {Id = 1, Name = "test"};
            var record2 = record1;
            record2.Name = "test2";
            var record3 = record1;
            record3.Name = null;

            var record4 = new Person {Id = 1, Name = "test"};

            record1.Equals(record2).Should().BeTrue();
            record2.Equals(record1).Should().BeTrue();

            record1.Equals(record3).Should().BeTrue();
            record3.Equals(record1).Should().BeTrue();

            record1.Equals(record4).Should().BeFalse(); // It's true for records
            record4.Equals(record1).Should().BeFalse(); // It's true for records
        }
    }
}