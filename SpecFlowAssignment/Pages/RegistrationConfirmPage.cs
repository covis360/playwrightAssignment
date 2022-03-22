using Microsoft.Playwright;

namespace SpecFlowAssignment.Pages;

public class RegistrationConfirmPage
{
    private IPage _page;

    public RegistrationConfirmPage(IPage page)
    {
        _page = page;
    }

    private string RegistrationUserMessage => ".title";
    private string RegistrationSuccesMessage => "text=Your account was created successfully. You are now logged in.";

    public async Task<string> GetRegistrationTitleMessage()
    {
        return await _page.InnerTextAsync(RegistrationUserMessage);
    }

    public async Task VerifyRegistrationMessageExist()
    {
        await _page.IsVisibleAsync(RegistrationSuccesMessage);
    }
}