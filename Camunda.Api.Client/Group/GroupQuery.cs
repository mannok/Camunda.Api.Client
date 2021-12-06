namespace Camunda.Api.Client.Group
{
    public class GroupQuery: QueryParameters
	{
		/// <summary>
		/// Filter by the id of the group.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Filter by the name of the group.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Filter by the name that the parameter is a substring of.
		/// </summary>
		public string NameLike { get; set; }

		/// <summary>
		/// Filter by the type of the group.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// Only retrieve groups which the given user id is a member of.
		/// </summary>
		public string Member { get; set; }

		/// <summary>
		/// Only retrieve groups which are members of the given tenant.
		/// </summary>
		public string MemberOfTenant { get; set; }

		/// <summary>
		/// Sort the results lexicographically by a given criterion. Must be used in conjunction with the <see cref="SortOrder"/>.
		/// </summary>
		public GroupSorting SortBy { get; set; }

		/// <summary>
		/// Sort the results in a given order. Must be used in conjunction with the <see cref="SortBy"/>.
		/// </summary>
		public SortOrder SortOrder { get; set; }
	}

	public enum GroupSorting
	{
		Id,
		Name,
		Type
	}
}
