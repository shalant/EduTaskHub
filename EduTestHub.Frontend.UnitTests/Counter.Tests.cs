using Bunit;
using EduTaskHub.Frontend.Components.Pages;

namespace EduTestHub.Frontend.UnitTests
{
    public class CounterTests
    {
        [Fact]
        public void OnCounterClick_WhenClickCounterButton_ShouldIncrementByOne()
        {
            // arrange
            using var ctx = new TestContext();
            var cut = ctx.Render<Counter>();
            cut.Find("p").InnerHtml.MarkupMatches("Current count: 0");

            // act
            cut.Find("button").Click();

            // assert
            cut.Find("p").InnerHtml.MarkupMatches("Current count: 1");
        }
    }
}