namespace Camunda.Api.Client
{
    public class SuspensionState
    {
        public bool Suspended { get; set; }

        public override string ToString() => Suspended.ToString();
    }
}
