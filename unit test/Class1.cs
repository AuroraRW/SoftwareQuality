using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleArea;
using NUnit.Framework;

namespace TriangleAreaTests
{
    public class Class1
    {
        [TestFixture]
        public class calculateArea
        {
            [Test]
            public void calculateArea_Base5point98andHeight6point75_Area20point1825()
            {
                //Arrange
                double triangleBase = 5.98;
                double triangleHeight = 6.75;

                double expectedResult = 20.1825;

                //Act
                double actualResult = TriangleArea.Program.calculateArea(triangleBase, triangleHeight);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
            [Test]
            public void calculateArea_Base6point0andHeight7point0_Area21()
            {
                //Arrange
                double triangleBase = 6.0;
                double triangleHeight = 7.0;

                double expectedResult = 21;

                //Act
                double actualResult = TriangleArea.Program.calculateArea(triangleBase, triangleHeight);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    }
    
}
