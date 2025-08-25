using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MunicipalReportingApp.DataStructures;

class Program
{
    static void Main(string[] args)
    {
        IssueLinkedList issues = new IssueLinkedList();

        issues.AddIssue("Broken streetlight", "Infrastructure");
        issues.AddIssue("Water leakage", "Utilities");
        issues.AddIssue("Pothole on Main Street", "Roads");

        Console.WriteLine("All Issues:");
        issues.DisplayIssues();

        Console.WriteLine("\nSearching for 'Water leakage':");
        var found = issues.SearchIssue("Water leakage");
        Console.WriteLine(found != null ? found.ToString() : "Issue not found");

        Console.WriteLine("\nRemoving 'Broken streetlight':");
        issues.RemoveIssue("Broken streetlight");
        issues.DisplayIssues();
    }
}


