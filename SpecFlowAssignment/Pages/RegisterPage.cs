using Microsoft.Playwright;

namespace SpecFlowAssignment.Pages;

public class RegisterPage
{
    private readonly IPage _page;

    public RegisterPage(IPage page)
    {
        _page = page;
    }

    //registration form
    private static string FirstName => "input[name=\"customer\\.firstName\"]";
    private string LastName => "input[name=\"customer\\.lastName\"]";
    private string Address => "input[name=\"customer\\.address\\.street\"]";
    private string City => "input[name=\"customer\\.address\\.city\"]";
    private string State => "input[name=\"customer\\.address\\.state\"]";
    private string ZipCode => "input[name=\"customer\\.address\\.zipCode\"]";
    private string PhoneNumber => "input[name=\"customer\\.phoneNumber\"]";
    private string Ssn => "input[name=\"customer\\.ssn\"]";
    private string UserName => "input[name=\"customer\\.username\"]";
    private string Password => "input[name=\"customer\\.password\"]";
    private string PasswordRepeat => "input[name=\"repeatedPassword\"]";
    private string ConfirmButton => "input:has-text(\"Register\")";
    

    public async Task FillFirstName(string firstName) => await _page.FillAsync(FirstName, firstName);
    public async Task FillLastName(string lastName) => await _page.FillAsync(LastName, lastName);
    public async Task FillAddress(string address) => await _page.FillAsync(Address, address);
    public async Task FillCity(string city) => await _page.FillAsync(City, city);
    public async Task FillState(string state) => await _page.FillAsync(State, state);
    public async Task FillZipCode(string zipCode) => await _page.FillAsync(ZipCode, zipCode);
    public async Task FillPhoneNumber(string phoneNumber) => await _page.FillAsync(PhoneNumber, phoneNumber);
    public async Task FillSsn(string ssn) => await _page.FillAsync(Ssn, ssn);
    public async Task FillUserName(string userName) => await _page.FillAsync(UserName, userName);
    public async Task FillPassword(string password) => await _page.FillAsync(Password, password);
    public async Task FillPasswordRepeat(string passwordRepeat) => await _page.FillAsync(PasswordRepeat, passwordRepeat);
    public async Task SubmitRegistrationForm() => await _page.ClickAsync(ConfirmButton);
}