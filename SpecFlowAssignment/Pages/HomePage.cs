using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SpecFlowAssignment.Pages;

public class HomePage
{
    private readonly IPage _page;

    public HomePage(IPage page)
    {
        _page = page;
    }


    private static string RegisterLink => "text='Register'";

    public async Task ClickRegister()
    {
        await _page.ClickAsync(RegisterLink);
    }
}