using Email_Service_Provider.Model;

namespace Email_Service_Provider.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
