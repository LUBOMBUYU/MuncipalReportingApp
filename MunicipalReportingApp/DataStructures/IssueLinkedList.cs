using System;
using System.Collections;
using System.Collections.Generic; // Ensure this is included

namespace MunicipalReportingApp.DataStructures
{
    public class IssueNode
    {
        public ReportedIssue Issue { get; set; }
        public IssueNode NextNode { get; set; } // Renamed to avoid ambiguity

        public IssueNode(ReportedIssue issue)
        {
            Issue = issue;
            NextNode = null;
        }
    }

    public class IssueLinkedList : IEnumerable<ReportedIssue>
    {
        private IssueNode head;
        private int count; // Track the number of issues

        public int Count => count; // Property to get the count

        public void AddIssue(string description, string category)
        {
            var newIssue = new ReportedIssue
            {
                Description = description,
                Category = category
            };
            var newNode = new IssueNode(newIssue);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.NextNode != null)
                {
                    current = current.NextNode;
                }
                current.NextNode = newNode;
            }
            count++; // Increment count when a new issue is added
        }

        public ReportedIssue SearchIssue(string description)
        {
            var current = head;
            while (current != null)
            {
                if (current.Issue.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
                {
                    return current.Issue;
                }
                current = current.NextNode;
            }
            return null;
        }

        public void RemoveIssue(string description)
        {
            if (head == null) return;

            if (head.Issue.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
            {
                head = head.NextNode;
                return;
            }

            var current = head;
            while (current.NextNode != null)
            {
                if (current.NextNode.Issue.Description.Equals(description, StringComparison.OrdinalIgnoreCase))
                {
                    current.NextNode = current.NextNode.NextNode;
                    return;
                }
                current = current.NextNode;
            }
        }

        public IEnumerator<ReportedIssue> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Issue;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator(); // Explicit interface implementation
    }
}
