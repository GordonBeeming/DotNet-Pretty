namespace DotNetPretty.Visualizers.TFS.DebuggerVisualizer.DialogDebuggerVisualizers
{
    using System;
    using System.Collections.Generic;

    using DotNetPretty.Visualizers.TFS.DebuggerVisualizer.Surrogates;
    using DotNetPretty.Visualizers.TFS.DebuggerVisualizer.Windows;

    using Microsoft.TeamFoundation.Client;
    using Microsoft.TeamFoundation.WorkItemTracking.Client;
    using Microsoft.VisualStudio.DebuggerVisualizers;

    public class WorkItemVisualizer : DialogDebuggerVisualizer
    {
        #region Methods

        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var surrogate = objectProvider.GetObject() as WorkItemSurrogate;
            var tfs = new TfsTeamProjectCollection(new Uri(surrogate.TfsUri), new TfsClientCredentials(new WindowsCredential(true), surrogate.FederatedClientCredential, true));
            var store = new WorkItemStore(tfs);
            WorkItem workItem = store.GetWorkItem(surrogate.Id);
            if (surrogate.IsDirty)
            {
                foreach (KeyValuePair<string, object> item in surrogate.Fields)
                {
                    try
                    {
                        workItem.Fields[item.Key].Value = item.Value;
                    }
                    catch
                    {
                        // set what we can =(
                    }
                }
            }
            var window = new WorkItemWindow(workItem);

            windowService.ShowDialog(window.AsForm());
        }

        #endregion
    }
}