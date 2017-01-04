namespace OddOccurrences.Tests
{
    using OddOccurrences.Core;

    using Xunit;

    public class OddOccurranceTests
    {
        [Theory]
        [InlineData(new[] { 9, 3, 9 }, 3)]
        [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        [InlineData(new int[0], 0)]
        public void OddOccurrance_FindsValueOccuresOddNumberOfTimes(int[] array, int expected)
        {
            var sut = new Solution();
            var actual = sut.OddOccurrence(array);
            Assert.Equal(expected, actual);
        }
    }
}
