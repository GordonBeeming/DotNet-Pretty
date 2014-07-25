namespace DotNetPretty.DesktopTestApp
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;

    using Microsoft.TeamFoundation.Client;
    using Microsoft.TeamFoundation.WorkItemTracking.Client;

    public partial class frmMain : Form
    {
        #region Constructors and Destructors

        public frmMain()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        private void btnMicrosoftTeamFoundationWorkItemTrackingClientWorkItem_Click(object sender, EventArgs e)
        {
            var tfs = new TfsTeamProjectCollection(new Uri(string.Format("http://{0}:8080/tfs", Environment.MachineName)), new TfsClientCredentials(new WindowsCredential(true), true));
            var store = new WorkItemStore(tfs);
            var workItemList = new List<WorkItem>(store.Query("SELECT Id, Title, [Work Item Type] FROM WorkItems").Cast<WorkItem>());
            if (workItemList.Count > 0)
            {
                workItemList[0].PartialOpen();
                workItemList[0].Title = string.Format("changed the title to show the date - {0}", DateTime.Now.ToString("dd MMM yyyy"));
                workItemList[0].Description = "bob is the description";
            }
            Debugger.Break();
        }

        private void btnSystemDataSqlClientSqlConnection_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(@"Server=.;Database=master;Integrated security=SSPI");
            Debugger.Break();
        }

        #endregion
    }
}