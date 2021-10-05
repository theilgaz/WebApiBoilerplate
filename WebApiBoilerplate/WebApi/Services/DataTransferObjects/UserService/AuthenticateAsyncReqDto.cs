using WebApi.IServices;

namespace WebApi.Services.DataTransferObjects.UserService
{
    /// <summary>
    /// Data transfer object for the <see cref="IUserService.AuthenticateAsync"/> request.
    /// </summary>
    public class AuthenticateAsyncReqDto
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }
    }
}