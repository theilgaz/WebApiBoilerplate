using WebApi.IServices;

namespace WebApi.Services.DataTransferObjects.UserService
{
    /// <summary>
    /// Data transfer object for the <see cref="IUserService.PasswordResetAsync"/> request.
    /// </summary>
    public class PasswordResetAsyncReqDto
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }
    }
}