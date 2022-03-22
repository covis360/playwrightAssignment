using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpecFlowAssignment.Hooks;
using SpecFlowAssignment.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowAssignment.Steps
{

    [Binding]
    public sealed class HomeSteps
    {
        private readonly Context _context;
        private readonly HomePage? _homePage = null;
        
        private readonly ScenarioContext _scenarioContext;

        public HomeSteps(ScenarioContext scenarioContext, Context context)
        {
            _scenarioContext = scenarioContext;
            _context = context;
            _homePage = new HomePage(_context.page);
        }

        [Given(@"parabank site is loaded")]
        public async Task GivenParabankSiteIsLoaded()
        {
            await _context.page.GotoAsync("https://parabank.parasoft.com/");
        }

        [Given(@"navigate to register page")]
        public async Task GivenNavigateToRegisterPage()
        {
            await _homePage?.ClickRegister()!;
        }
    }
}