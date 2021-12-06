namespace Camunda.Api.Client.Group
{
    public class GroupInfo
	{
		/// <summary>
		/// The id of the group
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// The name of the group.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The type of the group.
		/// </summary>	
		public string Type { get; set; }

		public override string ToString() => Id;
	}
}
