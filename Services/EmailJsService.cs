using Microsoft.JSInterop;
using Microsoft.Extensions.Configuration;

namespace portfolio.Services;

public class EmailJsService : IEmailService
{
    private readonly IJSRuntime _jsRuntime;
    private readonly EmailConfiguration _config;

    public EmailJsService(IJSRuntime jsRuntime, IConfiguration configuration)
    {
        _jsRuntime = jsRuntime;
        _config = new EmailConfiguration
        {
            ServiceId = configuration["EmailJS:ServiceId"] ?? "",
            TemplateId = configuration["EmailJS:TemplateId"] ?? "",
            PublicKey = configuration["EmailJS:PublicKey"] ?? "",
            RecipientEmail = configuration["EmailJS:RecipientEmail"] ?? ""
        };
    }

    public async Task<bool> SendEmailAsync(string name, string email, string subject, string message)
    {
        try
        {
            var templateParams = new
            {
                from_name = name,
                from_email = email,
                subject = subject,
                message = message,
                to_name = "Austin Massey"
            };

            var result = await _jsRuntime.InvokeAsync<string>("sendEmail", 
                _config.ServiceId, 
                _config.TemplateId, 
                templateParams, 
                _config.PublicKey);

            return result == "OK";
        }
        catch (Exception)
        {
            return false;
        }
    }
}
