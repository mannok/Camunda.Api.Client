namespace Camunda.Api.Client.History
{
    public class ReportResult
    {
        /// <summary>
        /// Specifies a timespan within a year. The period must be interpreted in conjunction with the returned <see cref="PeriodUnit"/>.
        /// </summary>
        public int Period { get; set; }
        /// <summary>
        /// The unit of the given period.
        /// </summary>
        public PeriodUnit PeriodUnit { get; set; }
    }
}
