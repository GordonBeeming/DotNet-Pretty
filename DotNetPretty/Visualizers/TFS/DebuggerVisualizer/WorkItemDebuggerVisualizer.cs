using System.Diagnostics;

using DotNetPretty.Visualizers.TFS.DebuggerVisualizer.DialogDebuggerVisualizers;
using DotNetPretty.Visualizers.TFS.DebuggerVisualizer.VisualizerObjectSources;

using Microsoft.TeamFoundation.WorkItemTracking.Client;

[assembly: DebuggerVisualizer(typeof(WorkItemVisualizer), typeof(WorkItemVisualizerObjectSource), Target = typeof(WorkItem), Description = "View Work Item")]