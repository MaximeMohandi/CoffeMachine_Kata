using cofeeemachine.services;

namespace cofeeMachineTest
{
    [TestFixture]
    public class InputDecoderTest
    {

        [TestCase(0, 1, false, "T:1:0")]
        [TestCase(2, 0, false, "H::")]
        [TestCase(1, 2, true, "Ch:2:0")]
        [TestCase(2, 2, true, "Hh:2:0")]
        [TestCase(3, 0, false, "O::")]
        [TestCase(3, 0, true, "O::")]
        public void WhenAskTea_thenMAkeDrink(int drinkCode, int nbSugar, bool extraHot, string expected)
        {
            var services = new DrinkServices();

            Assert.That(services.GetDrink(drinkCode, nbSugar, extraHot), Is.EqualTo(expected));
        }
    }
}
