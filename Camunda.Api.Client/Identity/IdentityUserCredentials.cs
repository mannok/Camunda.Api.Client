namespace Camunda.Api.Client.Identity
{
    internal class IdentityUserCredentials
    {
        /// <summary>
        /// The id of the user to verify
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The password of the user to verify
        /// </summary>
        public string Password { get; set; }

    }
}
