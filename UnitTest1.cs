using static Lab5_3;
using Xunit;
namespace Lab5_3TestUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double r = 1.00;
            
            

            
            double actual = 1.08526; 

            
            double calculatedValue = h(r + 1) + Math.Pow(h(Math.Pow(r, 2) + 1), 2) + 1;

           
            Assert.Equal(calculatedValue, actual, 5); 
        }
    }
}