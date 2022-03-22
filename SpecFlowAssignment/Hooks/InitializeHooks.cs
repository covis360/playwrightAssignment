using Microsoft.Playwright;
using SpecFlowAssignment.Base;

namespace SpecFlowAssignment.Hooks
{
    [Binding]
    class InitializeHooks
    {
        Context _context;

        public InitializeHooks(Context context)
        {
            _context = context;
        }

        [BeforeScenario]
        public async Task BeforeScenario()
        {
            PlaywrightDriver playwrightDriver = new PlaywrightDriver();
            BrowserTypeLaunchOptions launchOptions = new BrowserTypeLaunchOptions()
            {
                Headless = false,
            };
            _context.page = await playwrightDriver.InitializePlaywright(Base.Browser.Chromium, launchOptions);
        }
    }   
}