using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60;

namespace CoffeeShopUnitTesting
{
    public class CoffeeTesting
    {
        //Datasæt til brug i testmetoderne. "yield return" itererer på en TestCaseData ad gange så kun en linje TestCaseData laves ad gangen.
        //Det smarte her er at datasættet kan genbruges til andre tests hvis nødvendigt.
        public static IEnumerable<TestCaseData> CoffeeRightPriceTestCases()
        {
            yield return new TestCaseData(new BlackCoffee(0, Blend.Bacca), 20);
            yield return new TestCaseData(new Cortado(0, Blend.Bacca), 25);
            yield return new TestCaseData(new Espresso(0, Blend.Bacca), 30);
            yield return new TestCaseData(new FlatWhite(0, Blend.Bacca), 35);
            yield return new TestCaseData(new Latte(0, Blend.Bacca), 40);
        }

        public static IEnumerable<TestCaseData> CoffeeCorrectStrengthTestCases()
        {
            yield return new TestCaseData(new BlackCoffee(0, Blend.Bacca), "Strong");
            yield return new TestCaseData(new Cortado(0, Blend.Bacca), "Medium");
            yield return new TestCaseData(new Espresso(0, Blend.Bacca), "Strong");
            yield return new TestCaseData(new FlatWhite(0, Blend.Bacca), "Medium");
            yield return new TestCaseData(new Latte(0, Blend.Bacca), "Weak");
        }

        //TestCaseSource bruges til at gennemgå et datasæt, her kalder den på metoden CoffeeTestCases som generer vores datasæt.
        [TestCaseSource(CoffeeRightPriceTestCases)]
        public void PriceMethod_RightPrice_ShouldPass(Coffee testCoffee, int expectedPrice)
        {
            //Assign

            // Act
            var actualPrice = testCoffee.Price();

            // Assert
            Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        }

        [TestCaseSource(nameof(CoffeeCorrectStrengthTestCases))]
        public void StrengthMethod_CorrectStrength_ShouldPass(Coffee testCoffee, string expectedStrength)
        {
            //Assign


            //Act
            var actualStrength = testCoffee.Strength();

            //Assert
            Assert.That(actualStrength, Is.EqualTo(expectedStrength));
        }

        [TestCase(6)]
        [TestCase(-1)]
        public void Discount_InvalidAmount_ShouldThrowException(int discount)
        {
            //Assign


            //Act
            TestDelegate testAction = () => new BlackCoffee(discount, Blend.Bacca);


            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(testAction);

        }





        //[Test]
        //public void BlackCoffee_PriceMethod_RightPrice_ShouldPass()
        //{
        //    //assign
        //    var testCoffee = new BlackCoffee(0, Blend.Bacca);
        //    var expectedPrice = 20;

        //    //act
        //    var actualPrice = testCoffee.Price();

        //    //assert
        //    Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        //}

        //[Test]
        //public void Cortado_PriceMethod_RightPrice_ShouldPass()
        //{
        //    //assign
        //    var testCoffee = new Cortado(0, Blend.Bacca);
        //    var expectedPrice = 25;

        //    //act
        //    var actualPrice = testCoffee.Price();

        //    //assert
        //    Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        //}

        //[Test]
        //public void Espresso_PriceMethod_RightPrice_ShouldPass()
        //{
        //    //assign
        //    var testCoffee = new Espresso(0, Blend.Bacca);
        //    var expectedPrice = 30;

        //    //act
        //    var actualPrice = testCoffee.Price();

        //    //assert
        //    Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        //}

        //[Test]
        //public void FlatWhite_PriceMethod_RightPrice_ShouldPass()
        //{
        //    //assign
        //    var testCoffee = new FlatWhite(0, Blend.Bacca);
        //    var expectedPrice = 35;

        //    //act
        //    var actualPrice = testCoffee.Price();

        //    //assert
        //    Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        //}

        //[Test]
        //public void Latte_PriceMethod_RightPrice_ShouldPass()
        //{
        //    //assign
        //    var testCoffee = new Latte(0, Blend.Bacca);
        //    var expectedPrice = 40;

        //    //act
        //    var actualPrice = testCoffee.Price();

        //    //assert
        //    Assert.That(actualPrice, Is.EqualTo(expectedPrice));
        //}
    }
}
