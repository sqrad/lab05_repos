using static  Lab5_1;
using Xunit;
namespace Lab5_1UnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double s = 5.3;
            double t = 2.5;

            double c;

            c = (Math.Pow(h(s, t), 4) + h(1.0, Math.Pow(s, 2) + Math.Pow(t, 2))) / (1.0 + Math.Pow(h(s * t, 1), 2));
            Assert.Equal(0.00746321, c, 8);    
        }
    }
}