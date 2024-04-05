namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void WhenAddTwoEqualIntegers_ShouldReturnCorrectSum()
        {
            // arrange
            int number1 = 10;
            int number2 = 10;

            // act
            int number3 = number1 + number2;

            // assert
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number3, 20);
        }

        [Test]
        public void WhenAddTwoEqualFloats_ShouldReturnCorrectSum()
        {
            // arrange
            int float1 = 10;
            int float2 = 10;

            // act
            int float3 = float1 + float2;

            // assert
            Assert.AreEqual(float1, float2);
            Assert.AreEqual(float3, 20);
        }

        [Test]
        public void WhenGivenTwoStrings_ShouldReturnConcatenation()
        {
            // arrange
            string text1 = "w lesie ";
            string text2 = "w lesie ";

            // act
            string text3 = text1 + text2;

            // assert
            Assert.AreEqual(text1, text2);
            Assert.AreEqual(text3, "w lesie w lesie ");
            Assert.AreEqual(text3.Length, text1.Length + text2.Length);
        }
    }
}
