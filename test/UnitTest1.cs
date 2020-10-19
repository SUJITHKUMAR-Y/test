using System;
using Xunit;
using srcc;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var TSg=new Student();
            TSg.Addgrade(90.8);
            TSg.Addgrade(75.6);
            TSg.Addgrade(91.5);
            TSg.Addgrade(68.9);
            TSg.Addgrade(85.5);
            //action
            var Tresult=TSg.GetStatistics();
            //assert
            Assert.Equal(90.16,Tresult.High);
        }
    }
}
