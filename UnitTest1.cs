using static Lab5_4;
using Xunit;
namespace Lab5_4TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test_P0()
        {
            int K = 1;
            int N = 15;
            double expected = P0(K, N);
            double actual = P0(K, N);
            Assert.Equal(expected, actual, 5); 
        }

        [Fact]
        public void Test_P1()
        {
            int K = 1;
            int N = 15;
            double expected = P0(K, N);
            double actual = P1(K, N, K);
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void Test_P2()
        {
            int K = 1;
            int N = 15;
            double expected = P0(K, N);
            double actual = P2(K, N, N);
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void Test_P3()
        {
            int K = 1;
            int N = 15;
            double expected = P0(K, N);
            double actual = P3(K, N, K, 1);
            Assert.Equal(expected, actual, 5);
        }

        [Fact]
        public void Test_P4()
        {
            int K = 1;
            int N = 15;
            double expected = P0(K, N);
            double actual = P4(K, N, N, 1);
            Assert.Equal(expected, actual, 5);
        }
    }
}