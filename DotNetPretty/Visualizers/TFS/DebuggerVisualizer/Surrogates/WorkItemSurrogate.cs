namespace DotNetPretty.Visualizers.TFS.DebuggerVisualizer.Surrogates
{
    using System;
    using System.Collections.Generic;

    using Microsoft.TeamFoundation.Client;

    [Serializable]
    public class WorkItemSurrogate
    {
        #region Public Properties

        public FederatedCredential FederatedClientCredential { get; set; }

        public Dictionary<string, object> Fields { get; set; }

        public int Id { get; set; }

        public bool IsDirty { get; set; }

        public string TfsUri { get; set; }

        #endregion
    }
}