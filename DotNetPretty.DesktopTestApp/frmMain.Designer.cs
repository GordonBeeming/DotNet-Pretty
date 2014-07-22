namespace DotNetPretty.DesktopTestApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSystemDataSqlClientSqlConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSystemDataSqlClientSqlConnection
            // 
            this.btnSystemDataSqlClientSqlConnection.Location = new System.Drawing.Point(12, 12);
            this.btnSystemDataSqlClientSqlConnection.Name = "btnSystemDataSqlClientSqlConnection";
            this.btnSystemDataSqlClientSqlConnection.Size = new System.Drawing.Size(267, 23);
            this.btnSystemDataSqlClientSqlConnection.TabIndex = 0;
            this.btnSystemDataSqlClientSqlConnection.Text = "System.Data.SqlClient.SqlConnection";
            this.btnSystemDataSqlClientSqlConnection.UseVisualStyleBackColor = true;
            this.btnSystemDataSqlClientSqlConnection.Click += new System.EventHandler(this.btnSystemDataSqlClientSqlConnection_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 277);
            this.Controls.Add(this.btnSystemDataSqlClientSqlConnection);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSystemDataSqlClientSqlConnection;
    }
}

