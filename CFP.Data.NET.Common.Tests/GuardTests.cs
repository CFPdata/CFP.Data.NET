using System;

using Xunit;

using CFP.Data.NET.Common.Helpers;

namespace CFP.Data.NET.Common.Tests
{
    public class GuardTests
    {
        [Fact]
        public void IsNotNull_WithNullValue_ShouldThrowArgumentException()
        {
            string param = null;
            
            var exception = Assert.Throws<ArgumentNullException>(() => Guard.IsNotNull(param, nameof(param)));
            Assert.Equal(nameof(param), exception.ParamName);
        }

        [Fact]
        public void IsNotNull_WithNonNullValue_ShouldComplete()
        {
            var param = "Don't fail me again... admiral";

            Guard.IsNotNull(param, nameof(param));
            Assert.True(true);
        }
    }
}
