namespace DotNetPretty.Visualizers.TFS.DebuggerVisualizer.VisualizerObjectSources
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using DotNetPretty.Visualizers.TFS.DebuggerVisualizer.Surrogates;

    using Microsoft.TeamFoundation.WorkItemTracking.Client;
    using Microsoft.VisualStudio.DebuggerVisualizers;

    public class WorkItemVisualizerObjectSource : VisualizerObjectSource
    {
        #region Public Methods and Operators

        public override void GetData(object target, Stream outgoingData)
        {
            var targetObject = target as WorkItem;
            Dictionary<string, object> fields = targetObject.Fields.Cast<Field>().ToDictionary(field => field.ReferenceName, field => field.Value);
            var surrogate = new WorkItemSurrogate
                            {
                                Fields = fields,
                                TfsUri = targetObject.Store.TeamProjectCollection.Uri.ToString(),
                                Id = targetObject.Id,
                                IsDirty = targetObject.IsDirty,
                                FederatedClientCredential = targetObject.Store.TeamProjectCollection.ClientCredentials.Federated,
                            };
            base.GetData(surrogate, outgoingData);
        }

        public override string ToString()
        {
            return "Test";
        }

        #endregion
    }
}