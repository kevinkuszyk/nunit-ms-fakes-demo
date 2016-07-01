using Microsoft.QualityTools.Testing.Fakes;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void Test()
        {
            // Arrange
            using (var context = ShimsContext.Create()) // UnitTestIsolationException is thrown here.
            {
                
            }

            // Act

            // Assert
            Assert.That(true, Is.True);
        }
    }
}
