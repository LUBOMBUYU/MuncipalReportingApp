using System.Collections.Generic;

namespace MunicipalReportingApp.DataStructures
{
    public class Issue
    {
        public string? Location { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public List<string> Attachments { get; set; } = new List<string>();
    }
}
