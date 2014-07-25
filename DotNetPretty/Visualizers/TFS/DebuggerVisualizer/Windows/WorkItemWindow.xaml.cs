namespace DotNetPretty.Visualizers.TFS.DebuggerVisualizer.Windows
{
    using System.Windows;

    using Microsoft.TeamFoundation.WorkItemTracking.Client;
    using Microsoft.TeamFoundation.WorkItemTracking.WpfControls;

    /// <summary>
    ///     Interaction logic for WorkItemWindow.xaml
    /// </summary>
    public partial class WorkItemWindow : Window
    {
        #region Fields

        private readonly WorkItem workItem;

        #endregion

        #region Constructors and Destructors

        public WorkItemWindow(WorkItem workItem)
        {
            this.InitializeComponent();

            this.workItem = workItem;
        }

        #endregion

        #region Methods

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = string.Format("{0} {1}: {2}", this.workItem.Type.Name, this.workItem.Id, this.workItem.Title);
            var workItemControl = new WorkItemControl();
            workItemControl.Item = this.workItem;
            this.GridContent.Children.Add(workItemControl);
        }

        #endregion
    }
}