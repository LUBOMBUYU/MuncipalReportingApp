using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MunicipalReportingApp.DataStructures;

namespace MunicipalReportingApp
{
    public static class IssueStorage
    {
        private static readonly string FilePath = "issues.json";
        public static readonly List<Issue> Issues;

        static IssueStorage()
        {
            Issues = LoadIssues();
        }

        private static List<Issue> LoadIssues()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Issue>();
            }

            var json = File.ReadAllText(FilePath);
            // If the file is empty or just whitespace, start with a new list.
            if (string.IsNullOrWhiteSpace(json)) return new List<Issue>();

            return JsonSerializer.Deserialize<List<Issue>>(json) ?? new List<Issue>();
        }

        public static void SaveIssues()
        {
            var json = JsonSerializer.Serialize(Issues, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}
