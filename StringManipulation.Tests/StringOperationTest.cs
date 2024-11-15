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
            // Arrange = Configurar todos los datos iniciales, datos de prueba, diferentes variantes u objetos que necesitan para la ejecución.
            var strOperations = new StringOperations();

            // Act = Ejecución de la prueba perse que se desea probar
            var result = strOperations.ConcatenateStrings("Hello", "Word");

            // Assert = Comprobación del resultado 
            Assert.Equal("Hello Word", result);
        }
    }
}
