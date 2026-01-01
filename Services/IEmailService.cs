namespace portfolio.Services;

public interface IEmailService
{
    Task<bool> SendEmailAsync(string name, string email, string subject, string message);
}

public class EmailConfiguration
{
    public string ServiceId { get; set; } = "";
    public string TemplateId { get; set; } = "";
    public string PublicKey { get; set; } = "";
    public string RecipientEmail { get; set; } = "";
}
