using System;
using System.Windows.Forms;

namespace MunicipalReportingApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Show current stored issues in console for verification
            Console.WriteLine("=== Current Stored Issues ===");
            if (IssueStorage.Issues.Count == 0)
            {
                Console.WriteLine("No issues stored yet.");
            }
            else
            {
                for (int i = 0; i < IssueStorage.Issues.Count; i++)
                {
                    var issue = IssueStorage.Issues[i];
                    Console.WriteLine($"Issue {i + 1}:");
                    Console.WriteLine($"  Location: {issue.Location}");
                    Console.WriteLine($"  Category: {issue.Category}");
                    Console.WriteLine($"  Description: {issue.Description}");
                    Console.WriteLine($"  Attachments: {string.Join(", ", issue.Attachments)}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=============================");
            
            Application.Run(new MainMenuForm());
        }    
    }
}
