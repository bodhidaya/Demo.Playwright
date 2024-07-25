using System.Text.RegularExpressions;
using Microsoft.Playwright.MSTest;


[TestClass]
public class LandingPageTests : PageTest
{
    [TestMethod(displayName:"Check title contains Playwright")]
    public async Task HasTitle()
    {
        // Arrange
        // Browse to the home page of Playwright.dev
        var url = "https://playwright.dev";

        // Act (Arrange and act are the same)
        var response = await Page.GotoAsync(url);

        // Assert whether the title contains "Playwright"
        Assert.AreEqual(200, response.Status);
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

    }
}