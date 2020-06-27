using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        


        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange- data to be acted on
            var book = new Book("test");
            book.AddGrade(88.3);
            book.AddGrade(77.9);
            book.AddGrade(88.6);
            
            //act- on data
            var result = book.GetStatistics();

            //assert
            Assert.Equal(84.9, result.Average, 1);
            Assert.Equal(77.9, result.Low);
            Assert.Equal(88.6, result.High);
            Assert.Equal('B', result.Letter);
            
        }
    }
}
