using NUnit.Framework;

namespace Clean.ZipCodeValidator.Test
{
    [TestFixture]
    public class ZipCodeValidatorTest
    {
        [Test, Description("should return false if an invalid zip code is provided")]
        public void ZipCodeValidator_InvalidZipCode_ReturnsFalse()
        {
            Assert.That(ZipCodeValidator.Validate("1234"), Is.EqualTo(false));
        }
    }
}
