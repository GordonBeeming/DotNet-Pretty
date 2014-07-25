using System.Windows;
using System.Windows.Forms;

public static class Forms
{
    #region Public Methods and Operators

    public static Form AsForm(this Window window)
    {
        var frm = new Form();
        frm.Load += (s, e) =>
        {
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.WindowStyle = WindowStyle.ToolWindow;
            window.ShowDialog();
            frm.DialogResult = DialogResult.OK;
        };
        return frm;
    }

    #endregion
}