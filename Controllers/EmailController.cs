using Email_Service_Provider.Model;
using Email_Service_Provider.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Email_Service_Provider.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : Controller
    {

        private readonly IMailService mailService;
        public EmailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
            {
            // Add validation
            if (request == null)
                return BadRequest("Request cannot be null");

            if (string.IsNullOrWhiteSpace(request.ToEmail))
                return BadRequest("Recipient email is required");

            if (string.IsNullOrWhiteSpace(request.Subject))
                return BadRequest("Subject is required");

            if (string.IsNullOrWhiteSpace(request.Body))
                return BadRequest("Email body is required");

            try
            {
                await mailService.SendEmailAsync(request);
                return Ok("Email sent successfully");
            }
            catch (Exception ex)
            {
                // Don't rethrow - return proper error response
                return StatusCode(500, $"Error sending email: {ex.Message}");
            }
        }
    }
}
