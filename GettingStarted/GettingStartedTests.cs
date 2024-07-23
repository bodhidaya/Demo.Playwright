using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace GettingStarted
{
    [TestClass]
    public class GettingStartedTests : PageTest
    {
        [TestMethod]
        public async Task HasTitle()
        {
            await Page.GotoAsync("https://playwright.dev");

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
        }
    }
}