using System.Diagnostics;

using Microsoft.TeamFoundation.WorkItemTracking.Client;

[assembly: DebuggerDisplay("[{State,nq}] {Id}: {Title,nq}", Target = typeof(WorkItem))]