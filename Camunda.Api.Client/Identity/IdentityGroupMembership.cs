using Newtonsoft.Json;
using System.Collections.Generic;

namespace Camunda.Api.Client.Identity
{
    public class IdentityGroupMembership
    {
        public IdentityGroupMembership()
        {
            Groups = new List<IdentityGroup>();
            GroupUsers = new List<IdentityUser>();
        }
        /// <summary>
        /// List of groups the user is a member of
        /// </summary>
        [JsonProperty("groups")]
        public List<IdentityGroup> Groups { get; set; }
        /// <summary>
        /// List of users who are members of any of the groups 
        /// </summary>
        [JsonProperty("groupUsers")]
        public List<IdentityUser> GroupUsers { get; set; }
    }

    public class IdentityGroup
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public override string ToString() => Id;
    }
    public class IdentityUser
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public override string ToString() => Id;
    }

}
