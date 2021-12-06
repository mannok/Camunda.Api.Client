namespace Camunda.Api.Client.User
{
    public class UserProfileInfo
    {
        /// <summary>
        /// The id of the user.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The firstname of the user.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The lastname of the user.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Email { get; set; }

        public override string ToString() => Id;
    }
}
