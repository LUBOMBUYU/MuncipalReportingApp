using System.Collections.Generic;

namespace MunicipalReportingApp
{
    // Static class to store all reported issues globally
    public static class IssueStorage
    {
        public static readonly List<ReportedIssue> Issues = new List<ReportedIssue>();
    }

    // This class represents a single reported issue
    public class ReportedIssue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string[] Attachments { get; set; }
    }
}
