namespace Camunda.Api.Client.UserTask
{
    public class AttachmentInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TaskId { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        public override string ToString() => Id;
    }
}
