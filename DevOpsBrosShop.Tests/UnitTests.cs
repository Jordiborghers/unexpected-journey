using System;
using Xunit;

namespace DevOpsBrosShop.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Truthy()
        {
            Assert.True(true);
        }
        
        [Fact]
        public void Falsy()
        {
            Assert.False(false);
        }
    }
}