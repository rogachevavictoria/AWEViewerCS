namespace AWEViewerCS
{
	partial class EmployeeViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeViewer));
            this.horizontalSplit = new System.Windows.Forms.SplitContainer();
            this.verticalSplit = new System.Windows.Forms.SplitContainer();
            this.employeesTreeView = new System.Windows.Forms.TreeView();
            this.viewerImageList = new System.Windows.Forms.ImageList(this.components);
            this.viewerToolStrip = new System.Windows.Forms.ToolStrip();
            this.viewerTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.viewAllPanel = new System.Windows.Forms.Panel();
            this.goButton = new System.Windows.Forms.Button();
            this.detailsRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeViewerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeContactsDataSet = new AWEViewerCS.EmployeeContactsDataSet();
            this.uspEmployeeContactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspEmployeeContactsTableAdapter = new AWEViewerCS.EmployeeContactsDataSetTableAdapters.uspEmployeeContactsTableAdapter();
            this.loadDataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.clearDataToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeePictureBox = new System.Windows.Forms.PictureBox();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalSplit.Panel1.SuspendLayout();
            this.horizontalSplit.Panel2.SuspendLayout();
            this.horizontalSplit.SuspendLayout();
            this.verticalSplit.Panel1.SuspendLayout();
            this.verticalSplit.Panel2.SuspendLayout();
            this.verticalSplit.SuspendLayout();
            this.viewerToolStrip.SuspendLayout();
            this.viewerTableLayout.SuspendLayout();
            this.viewAllPanel.SuspendLayout();
            this.employeeViewerMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeContactsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspEmployeeContactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // horizontalSplit
            // 
            this.horizontalSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horizontalSplit.Location = new System.Drawing.Point(0, 28);
            this.horizontalSplit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.horizontalSplit.Name = "horizontalSplit";
            this.horizontalSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // horizontalSplit.Panel1
            // 
            this.horizontalSplit.Panel1.Controls.Add(this.verticalSplit);
            // 
            // horizontalSplit.Panel2
            // 
            this.horizontalSplit.Panel2.Controls.Add(this.viewerTableLayout);
            this.horizontalSplit.Panel2.Controls.Add(this.viewAllPanel);
            this.horizontalSplit.Size = new System.Drawing.Size(723, 536);
            this.horizontalSplit.SplitterDistance = 284;
            this.horizontalSplit.SplitterWidth = 5;
            this.horizontalSplit.TabIndex = 0;
            this.horizontalSplit.Text = "splitContainer1";
            // 
            // verticalSplit
            // 
            this.verticalSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplit.Location = new System.Drawing.Point(0, 0);
            this.verticalSplit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.verticalSplit.Name = "verticalSplit";
            // 
            // verticalSplit.Panel1
            // 
            this.verticalSplit.Panel1.Controls.Add(this.employeesTreeView);
            this.verticalSplit.Panel1.Controls.Add(this.viewerToolStrip);
            // 
            // verticalSplit.Panel2
            // 
            this.verticalSplit.Panel2.Controls.Add(this.employeePictureBox);
            this.verticalSplit.Size = new System.Drawing.Size(723, 284);
            this.verticalSplit.SplitterDistance = 342;
            this.verticalSplit.SplitterWidth = 5;
            this.verticalSplit.TabIndex = 0;
            this.verticalSplit.Text = "splitContainer1";
            // 
            // employeesTreeView
            // 
            this.employeesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesTreeView.ImageIndex = 0;
            this.employeesTreeView.ImageList = this.viewerImageList;
            this.employeesTreeView.Location = new System.Drawing.Point(0, 27);
            this.employeesTreeView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeesTreeView.Name = "employeesTreeView";
            this.employeesTreeView.SelectedImageIndex = 0;
            this.employeesTreeView.Size = new System.Drawing.Size(342, 257);
            this.employeesTreeView.TabIndex = 0;
            this.employeesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.employeesTreeView_AfterSelect);
            // 
            // viewerImageList
            // 
            this.viewerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("viewerImageList.ImageStream")));
            this.viewerImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.viewerImageList.Images.SetKeyName(0, "OrgChart.bmp");
            this.viewerImageList.Images.SetKeyName(1, "user.ico");
            this.viewerImageList.Images.SetKeyName(2, "Checkbox.bmp");
            // 
            // viewerToolStrip
            // 
            this.viewerToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.viewerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripButton,
            this.clearDataToolStripButton});
            this.viewerToolStrip.Location = new System.Drawing.Point(0, 0);
            this.viewerToolStrip.Name = "viewerToolStrip";
            this.viewerToolStrip.Size = new System.Drawing.Size(342, 27);
            this.viewerToolStrip.TabIndex = 1;
            this.viewerToolStrip.Text = "toolStrip1";
            // 
            // viewerTableLayout
            // 
            this.viewerTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.viewerTableLayout.ColumnCount = 2;
            this.viewerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.viewerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.viewerTableLayout.Controls.Add(this.phoneLabel, 0, 0);
            this.viewerTableLayout.Controls.Add(this.phoneTextBox, 1, 0);
            this.viewerTableLayout.Controls.Add(this.emailLabel, 0, 1);
            this.viewerTableLayout.Controls.Add(this.emailTextBox, 1, 1);
            this.viewerTableLayout.Location = new System.Drawing.Point(333, 55);
            this.viewerTableLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewerTableLayout.Name = "viewerTableLayout";
            this.viewerTableLayout.RowCount = 2;
            this.viewerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.viewerTableLayout.Size = new System.Drawing.Size(369, 135);
            this.viewerTableLayout.TabIndex = 0;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(5, 25);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(49, 17);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspEmployeeContactsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(107, 23);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(212, 22);
            this.phoneTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 92);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(47, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uspEmployeeContactsBindingSource, "EmailAddress", true));
            this.emailTextBox.Location = new System.Drawing.Point(107, 90);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(212, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // viewAllPanel
            // 
            this.viewAllPanel.Controls.Add(this.goButton);
            this.viewAllPanel.Controls.Add(this.detailsRadioButton);
            this.viewAllPanel.Location = new System.Drawing.Point(53, 55);
            this.viewAllPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewAllPanel.Name = "viewAllPanel";
            this.viewAllPanel.Size = new System.Drawing.Size(213, 135);
            this.viewAllPanel.TabIndex = 0;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(40, 86);
            this.goButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(120, 27);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // detailsRadioButton
            // 
            this.detailsRadioButton.AutoSize = true;
            this.detailsRadioButton.Location = new System.Drawing.Point(40, 37);
            this.detailsRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailsRadioButton.Name = "detailsRadioButton";
            this.detailsRadioButton.Size = new System.Drawing.Size(124, 21);
            this.detailsRadioButton.TabIndex = 0;
            this.detailsRadioButton.Text = "View All Details";
            // 
            // employeeViewerMenuStrip
            // 
            this.employeeViewerMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.employeeViewerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.treeViewToolStripMenuItem1});
            this.employeeViewerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.employeeViewerMenuStrip.Name = "employeeViewerMenuStrip";
            this.employeeViewerMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.employeeViewerMenuStrip.Size = new System.Drawing.Size(723, 28);
            this.employeeViewerMenuStrip.TabIndex = 1;
            this.employeeViewerMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // treeViewToolStripMenuItem1
            // 
            this.treeViewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.clearDataToolStripMenuItem});
            this.treeViewToolStripMenuItem1.Name = "treeViewToolStripMenuItem1";
            this.treeViewToolStripMenuItem1.Size = new System.Drawing.Size(85, 24);
            this.treeViewToolStripMenuItem1.Text = "&Tree View";
            // 
            // employeeContactsDataSet
            // 
            this.employeeContactsDataSet.DataSetName = "EmployeeContactsDataSet";
            this.employeeContactsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspEmployeeContactsBindingSource
            // 
            this.uspEmployeeContactsBindingSource.DataMember = "uspEmployeeContacts";
            this.uspEmployeeContactsBindingSource.DataSource = this.employeeContactsDataSet;
            // 
            // uspEmployeeContactsTableAdapter
            // 
            this.uspEmployeeContactsTableAdapter.ClearBeforeFill = true;
            // 
            // loadDataToolStripButton
            // 
            this.loadDataToolStripButton.Image = global::AWEViewerCS.Properties.Resources.database;
            this.loadDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadDataToolStripButton.Name = "loadDataToolStripButton";
            this.loadDataToolStripButton.Size = new System.Drawing.Size(102, 24);
            this.loadDataToolStripButton.Text = "Load Data";
            this.loadDataToolStripButton.Click += new System.EventHandler(this.loadDataToolStripButton_Click);
            // 
            // clearDataToolStripButton
            // 
            this.clearDataToolStripButton.Image = global::AWEViewerCS.Properties.Resources.RolledBack;
            this.clearDataToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearDataToolStripButton.Name = "clearDataToolStripButton";
            this.clearDataToolStripButton.Size = new System.Drawing.Size(103, 24);
            this.clearDataToolStripButton.Text = "Clear Data";
            this.clearDataToolStripButton.Click += new System.EventHandler(this.clearDataToolStripButton_Click);
            // 
            // employeePictureBox
            // 
            this.employeePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePictureBox.Location = new System.Drawing.Point(0, 0);
            this.employeePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeePictureBox.Name = "employeePictureBox";
            this.employeePictureBox.Size = new System.Drawing.Size(376, 284);
            this.employeePictureBox.TabIndex = 0;
            this.employeePictureBox.TabStop = false;
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Image = global::AWEViewerCS.Properties.Resources.database;
            this.loadDataToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.loadDataToolStripMenuItem.Text = "&Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripButton_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Image = global::AWEViewerCS.Properties.Resources.RolledBack;
            this.clearDataToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.clearDataToolStripMenuItem.Text = "&Clear Data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripButton_Click);
            // 
            // EmployeeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 564);
            this.Controls.Add(this.horizontalSplit);
            this.Controls.Add(this.employeeViewerMenuStrip);
            this.MainMenuStrip = this.employeeViewerMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Viewer";
            this.horizontalSplit.Panel1.ResumeLayout(false);
            this.horizontalSplit.Panel2.ResumeLayout(false);
            this.horizontalSplit.ResumeLayout(false);
            this.verticalSplit.Panel1.ResumeLayout(false);
            this.verticalSplit.Panel1.PerformLayout();
            this.verticalSplit.Panel2.ResumeLayout(false);
            this.verticalSplit.ResumeLayout(false);
            this.viewerToolStrip.ResumeLayout(false);
            this.viewerToolStrip.PerformLayout();
            this.viewerTableLayout.ResumeLayout(false);
            this.viewerTableLayout.PerformLayout();
            this.viewAllPanel.ResumeLayout(false);
            this.viewAllPanel.PerformLayout();
            this.employeeViewerMenuStrip.ResumeLayout(false);
            this.employeeViewerMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeContactsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspEmployeeContactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer horizontalSplit;
		private System.Windows.Forms.SplitContainer verticalSplit;
		private System.Windows.Forms.TreeView employeesTreeView;
		private System.Windows.Forms.PictureBox employeePictureBox;
		private System.Windows.Forms.ToolStrip viewerToolStrip;
		private System.Windows.Forms.ToolStripButton loadDataToolStripButton;
		private System.Windows.Forms.ToolStripButton clearDataToolStripButton;
		private System.Windows.Forms.Panel viewAllPanel;
		private System.Windows.Forms.RadioButton detailsRadioButton;
		private System.Windows.Forms.Button goButton;
		private System.Windows.Forms.TableLayoutPanel viewerTableLayout;
		private System.Windows.Forms.Label phoneLabel;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.ImageList viewerImageList;
		private System.Windows.Forms.MenuStrip employeeViewerMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem treeViewToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.BindingSource uspEmployeeContactsBindingSource;
        private EmployeeContactsDataSet employeeContactsDataSet;
        private EmployeeContactsDataSetTableAdapters.uspEmployeeContactsTableAdapter uspEmployeeContactsTableAdapter;
    }
}