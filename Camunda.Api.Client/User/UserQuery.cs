namespace Camunda.Api.Client.User
{
    public class UserQuery : QueryParameters
    {
        /// <summary>
        /// Filter by the id of the user.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Filter by the firstname of the user.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Filter by the firstname that the parameter is a substring of.
        /// </summary>
        public string FirstNameLike { get; set; }
        /// <summary>
        /// Filter by the lastname of the user.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Filter by the lastname that the parameter is a substring of.
        /// </summary>
        public string LastNameLike { get; set; }
        /// <summary>
        /// Filter by the email of the user.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Filter by the email that the parameter is a substring of.
        /// </summary>
        public string EmailLike { get; set; }
        /// <summary>
        /// Filter for users which are members of a group.
        /// </summary>
        public string MemberOfGroup { get; set; }
        /// <summary>
        /// Filter for users which are members of the given tenant.
        /// </summary>
        public string MemberOfTenant { get; set; }

        /// <summary>
        /// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/>.
        /// </summary>
        public UserSorting SortBy { get; set; }
        /// <summary>
        /// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/>.
        /// </summary>
        public SortOrder SortOrder { get; set; }
    }

    public enum UserSorting
    {
        UserId,
        FirstName,
        LastName,
        Email,
    }
}