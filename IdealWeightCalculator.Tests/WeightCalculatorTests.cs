using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdealWeightCalculator.Tests
{
    [TestClass]
    public class WeightCalculatorTests
    {
        //Given_When_Then
        [TestMethod]
        public void GetIdealBodyWeight_Sex_M_And_Height_180_Return_72_5()
        {
            //Arrange
            WeightCalculator sut = new WeightCalculator
            {
                Height = 180,
                Sexe = 'm'
            };

            //Act
            double actual = sut.GetIdealBodyWeight();
            double expected = 72.5;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        //Given_When_Then
        [TestMethod]
        public void GetIdealBodyWeight_Sex_W_And_Height_180_Return_65()
        {
            //Arrange
            WeightCalculator sut = new WeightCalculator
            {
                Height = 180,
                Sexe = 'w'
            };

            //Act
            double actual = sut.GetIdealBodyWeight();
            double expected = 65;

            //Assert
            Assert.AreEqual(actual, expected);
        }

        //Given_When_Then
        [TestMethod]
        public void GetIdealBodyWeight_UnknouwnSex_And_Height_180_Return_0()
        {
            //Arrange
            WeightCalculator sut = new WeightCalculator
            {
                Height = 180,
                Sexe = 's'
            };

            //Act
            double actual = sut.GetIdealBodyWeight();
            double expected = 0;

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
