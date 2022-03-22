using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.Playwright;
using NUnit.Framework;
using SpecFlowAssignment.Helpers;
using SpecFlowAssignment.Hooks;
using SpecFlowAssignment.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowAssignment.Steps
{
    [Binding]
    public sealed class RegisterSteps
    {
        private readonly Context _context;
        private readonly RegisterPage _registerPage;
        private readonly RegistrationConfirmPage _registrationConfirmPage;
        private readonly ScenarioContext _scenarioContext;

        public RegisterSteps(ScenarioContext scenarioContext, Context context)
        {
            _scenarioContext = scenarioContext;
            _context = context;
            _registerPage = new RegisterPage(_context.page);
            _registrationConfirmPage = new RegistrationConfirmPage(_context.page);
        }
        
        [Given(@"Fill and submit registration form")]
        public async Task GivenFillAndSubmitRegistrationForm(Table table)
        {
            var dictionary = TableExtensions.ToDictionary(table);
            var firstName = dictionary["firstName"];
            var lastName = dictionary["lastName"];
            var address = dictionary["address"];
            var city = dictionary["city"];
            var state = dictionary["state"];
            var zipCode = dictionary["zipCode"];
            var phoneNumber = dictionary["phoneNumber"];
            var ssn = dictionary["ssn"];
            var userName = dictionary["userName"];
            var password = dictionary["password"];
            var passwordRepeat = dictionary["passwordRepeat"];

            //fill user form
            await _registerPage.FillFirstName(firstName);
            await _registerPage.FillLastName(lastName);
            await _registerPage.FillAddress(address);
            await _registerPage.FillCity(city);
            await _registerPage.FillState(state);
            await _registerPage.FillZipCode(zipCode);
            await _registerPage.FillPhoneNumber(phoneNumber);
            await _registerPage.FillSsn(ssn);
            await _registerPage.FillUserName(userName);
            await _registerPage.FillPassword(password);
            await _registerPage.FillPasswordRepeat(passwordRepeat);

            await _registerPage.SubmitRegistrationForm();
        }

        [Then(@"Verify user is registered")]
        public async Task ThenVerifyUserIsRegistered()
        {
            var registrationMessage = await _registrationConfirmPage.GetRegistrationTitleMessage();
            StringAssert.Contains("Welcome",registrationMessage);
            await _registrationConfirmPage.VerifyRegistrationMessageExist();
        }
    }

}