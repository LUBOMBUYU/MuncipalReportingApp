using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalReportingApp.DataStructures
{
    internal class IssueNode
    {
        public string Description { get; set; }  // Example: "Broken streetlight"
        public string Category { get; set; }     // Example: "Infrastructure"
        public IssueNode? Next { get; set; }     // Points to the next node in the list

        public IssueNode(string description, string category)
        {
            Description = description;
            Category = category;
            Next = null;
        }

        public override string ToString()
        {
            return $"[Issue: {Description}, Category: {Category}]";
        }
    }
}