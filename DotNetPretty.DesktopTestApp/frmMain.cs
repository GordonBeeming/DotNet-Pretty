using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetPretty.DesktopTestApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSystemDataSqlClientSqlConnection_Click(object sender, EventArgs e)
        {
            var conn = new SqlConnection(@"Server=.;Database=master;Integrated security=SSPI");
            Debugger.Break();
        }
    }
}
