using static Lab5_2;
using Xunit;
namespace Lab5_2TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double a = 1.0;
            
            double x = 0;
            int n = 1;

            double expectation = 0.0;
            A(x, n, ref a);
            Assert.Equal(expectation, a);
        }
    }
}