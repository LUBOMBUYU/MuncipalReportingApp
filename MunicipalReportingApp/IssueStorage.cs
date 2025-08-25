﻿﻿using System.Collections.Generic;
using MunicipalReportingApp.DataStructures;

namespace MunicipalReportingApp
{
    // Static class to store all reported issues globally
    public static class IssueStorage
    {
        public static readonly List<Issue> Issues = new List<Issue>();
    }
}
