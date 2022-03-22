using Microsoft.Playwright;

namespace SpecFlowAssignment.Base
{
    public enum Browser
    {
        Chromium,
        Firefox
    }

    public class PlaywrightDriver
    {
        public IPage page { get; set; }

        public async Task<IPage> InitializePlaywright(Browser browser, BrowserTypeLaunchOptions launchOptions)
        {
            var playwright = await Playwright.CreateAsync();
            IBrowser iBrowser = null;
            if (browser == Browser.Chromium)
                iBrowser = await playwright.Chromium.LaunchAsync(launchOptions);
            if (browser == Browser.Firefox)
                iBrowser = await playwright.Firefox.LaunchAsync(launchOptions);
            page = await iBrowser.NewPageAsync();
            return page;
        }
    }    
}
