namespace OddOccurrences.Tests
{
    using OddOccurrences.Core;

    using Xunit;

    public class OddOccurranceTests
    {
        [Theory]
        [InlineData(new[] { 9, 3, 9 }, 3)]
        public void OddOccurrance_FindsValueOccuresOddNumberOfTimes(int[] array, int expected)
        {
            var sut = new Solution();
            var actual = sut.OddOccurrence(array);
            Assert.Equal(expected, actual);
        }
    }
}
