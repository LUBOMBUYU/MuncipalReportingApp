﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace MunicipalReportingApp.DataStructures
{
    public class IssueNode
    {
        public Issue Issue { get; set; }
        public IssueNode NextNode { get; set; }

        public IssueNode(Issue issue)
        {
            Issue = issue;
            NextNode = null;
        }
    }

    public class IssueLinkedList : IEnumerable<Issue>
    {
        private IssueNode head;
        private int count;

        public int Count => count;

        public void Add(Issue issue)
        {
            var newNode = new IssueNode(issue);

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
            count++;
        }

        public Issue SearchIssue(string description)
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

        public IEnumerator<Issue> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Issue;
                current = current.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
