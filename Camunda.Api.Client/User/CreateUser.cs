namespace Camunda.Api.Client.User
{
    internal class CreateUser
    {
        public UserProfileInfo Profile { get; set; }

        public UserCredentialsInfo Credentials { get; set; }
    }
}
