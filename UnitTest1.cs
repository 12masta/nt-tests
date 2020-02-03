using NUnit.Framework;
using FluentAssertions;

namespace nt_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            true.Should().BeTrue();
        }

        [Test]
        public void String_Test()
        {
            "".Should().Be("");
        }

        [Test]
        public void My_first_string_String_Test()
        {
            "moje pierwsze testy".Should().Be("moje pierwsze testy");
            "moje pierwsze testy".Should().NotBe("moje pierwsze ty");
        }
    }
}