using System;

namespace Camunda.Api.Client.UserTask
{
    public class CommentInfo : Comment
    {
        /// <summary>
        /// The id of the task comment.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The id of the user who created the comment.
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// The time when the comment was created.
        /// </summary>
        public DateTime Time { get; set; }
        /// <summary>
        /// The id of the task to which the comment belongs.
        /// </summary>
        public string TaskId { get; set; }

        public override string ToString() => base.ToString() ?? Id;
    }
}
