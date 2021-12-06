using System;

namespace Camunda.Api.Client.Filter
{
    public class FilterInfo
    {
        public class Request
        {
            public Request()
            {
                ResourceType = "Task";
            }
            
            /// <summary>
            /// The resource type of the filter.
            /// </summary>
            public string ResourceType { get; set; }

            /// <summary>
            /// The name of the filter.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// The user id of the owner of the filter.
            /// </summary>
            public string Owner { get; set; }

            /// <summary>
            /// The query of the filter as a JSON object.
            /// </summary>
            public object Query { get; set; }

            /// <summary>
            /// The properties of a filter as a JSON object.
            /// </summary>
            public object Properties { get; set; }
        }

        public class Response
        {
            /// <summary>
            ///  The id of the filter.
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// The resource type of the filter.
            /// </summary>
            public string ResourceType { get; set; }

            /// <summary>
            /// The name of the filter.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// The user id of the owner of the filter.
            /// </summary>
            public string Owner { get; set; }

            /// <summary>
            /// The query of the filter as a JSON object.
            /// </summary>
            public object Query { get; set; }

            /// <summary>
            /// The properties of a filter as a JSON object.
            /// </summary>
            public object Properties { get; set; }

            /// <summary>
            /// The number of items matched by the filter itself.Note: Only exists if the query parameter itemCount was set to true
            /// </summary>
            public long? ItemCount { get; set; }
        }
    }
}
