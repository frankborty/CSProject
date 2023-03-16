using PrimeFactorsLib;

namespace PrimeFactorsTests
{
    public class PrimesTest
    {
        [Fact]
        public void TestFact40()
        {
            string expected = "5 x 2 x 2 x 2";

            string result = Primes.PrimeFactors(40);

            Assert.Equal(expected, result);
        }
    }
}