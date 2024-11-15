using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Tests
{
    public class StringOperationTest
    {
        [Fact]
        public void ConcatenateStrings()
        {
            var strOperations = new StringOperations();

            var result = strOperations.ConcatenateStrings("Hello", "Word");

            Assert.Equal("Hello Word", result);
        }
    }
}
