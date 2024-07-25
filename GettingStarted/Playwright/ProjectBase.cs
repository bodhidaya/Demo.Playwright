using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace GettingStarted.Playwright;

public class ProjectBase : PageTest
{
    // TODO: write helper methods for your project
    public async Task CheckTitle( string expectedTitle)
    {
        await Expect(Page).ToHaveTitleAsync(new Regex(expectedTitle));
    }

    public void IsSuccessfulStatus(IResponse response)
    {
        Assert.IsTrue(response.Status == 200);
    }
}