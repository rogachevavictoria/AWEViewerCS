namespace AWEViewerCS
{
	partial class ReportGenerator
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Day",
            "7:00am - 3:00pm"}, -1);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Evening",
            "3:00pm - 11:00pm"}, -1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Night",
            "11:00pm - 7:00am"}, -1);
			this.reportToolStrip = new System.Windows.Forms.ToolStrip();
			this.viewResultsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.reportLabel = new System.Windows.Forms.Label();
			this.reportTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.tableContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.viewResultsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsLabel = new System.Windows.Forms.Label();
			this.operatorsLabel = new System.Windows.Forms.Label();
			this.criteriaLabel = new System.Windows.Forms.Label();
			this.sickLeaveRadioButton = new System.Windows.Forms.RadioButton();
			this.sickLeaveComboBox = new System.Windows.Forms.ComboBox();
			this.sickLeaveNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.deptRadioButton = new System.Windows.Forms.RadioButton();
			this.hireDateRadioButton = new System.Windows.Forms.RadioButton();
			this.hireDateComboBox = new System.Windows.Forms.ComboBox();
			this.hireDateMonthCalendar = new System.Windows.Forms.MonthCalendar();
			this.deptCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.departmentContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.shiftListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.shiftRadioButton = new System.Windows.Forms.RadioButton();
			this.reportGeneratorMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportToolStrip.SuspendLayout();
			this.reportTableLayout.SuspendLayout();
			this.tableContextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sickLeaveNumericUpDown)).BeginInit();
			this.departmentContextMenuStrip.SuspendLayout();
			this.reportGeneratorMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// reportToolStrip
			// 
			this.reportToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultsToolStripButton,
            this.helpToolStripButton});
			this.reportToolStrip.Location = new System.Drawing.Point(0, 24);
			this.reportToolStrip.Name = "reportToolStrip";
			this.reportToolStrip.Size = new System.Drawing.Size(472, 25);
			this.reportToolStrip.TabIndex = 0;
			this.reportToolStrip.Text = "toolStrip1";
			// 
			// viewResultsToolStripButton
			// 
			this.viewResultsToolStripButton.Image = AWEViewerCS.Properties.Resources.GoLtr;
			this.viewResultsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewResultsToolStripButton.Name = "viewResultsToolStripButton";
			this.viewResultsToolStripButton.Text = "View Results";
			this.viewResultsToolStripButton.Click += new System.EventHandler(this.viewResultsToolStripButton_Click);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = AWEViewerCS.Properties.Resources.Help;
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Text = "Help";
			this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
			// 
			// reportLabel
			// 
			this.reportLabel.AutoSize = true;
			this.reportLabel.Location = new System.Drawing.Point(12, 61);
			this.reportLabel.Name = "reportLabel";
			this.reportLabel.Size = new System.Drawing.Size(298, 13);
			this.reportLabel.TabIndex = 1;
			this.reportLabel.Text = "Select one option, fill in the criteria and then click View Results";
			// 
			// reportTableLayout
			// 
			this.reportTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
			this.reportTableLayout.ColumnCount = 3;
			this.reportTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.reportTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.reportTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.reportTableLayout.ContextMenuStrip = this.tableContextMenuStrip;
			this.reportTableLayout.Controls.Add(this.optionsLabel, 0, 0);
			this.reportTableLayout.Controls.Add(this.operatorsLabel, 1, 0);
			this.reportTableLayout.Controls.Add(this.criteriaLabel, 2, 0);
			this.reportTableLayout.Controls.Add(this.sickLeaveRadioButton, 0, 1);
			this.reportTableLayout.Controls.Add(this.sickLeaveComboBox, 1, 1);
			this.reportTableLayout.Controls.Add(this.sickLeaveNumericUpDown, 2, 1);
			this.reportTableLayout.Controls.Add(this.deptRadioButton, 0, 3);
			this.reportTableLayout.Controls.Add(this.hireDateRadioButton, 0, 4);
			this.reportTableLayout.Controls.Add(this.hireDateComboBox, 1, 4);
			this.reportTableLayout.Controls.Add(this.hireDateMonthCalendar, 2, 4);
			this.reportTableLayout.Controls.Add(this.deptCheckedListBox, 2, 3);
			this.reportTableLayout.Controls.Add(this.shiftListView, 2, 2);
			this.reportTableLayout.Controls.Add(this.shiftRadioButton, 0, 2);
			this.reportTableLayout.Location = new System.Drawing.Point(13, 77);
			this.reportTableLayout.Name = "reportTableLayout";
			this.reportTableLayout.RowCount = 5;
			this.reportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.reportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.reportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.reportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.reportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.reportTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.reportTableLayout.Size = new System.Drawing.Size(430, 390);
			this.reportTableLayout.TabIndex = 2;
			// 
			// tableContextMenuStrip
			// 
			this.tableContextMenuStrip.Enabled = true;
			this.tableContextMenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
			this.tableContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewResultsToolStripMenuItem1,
            this.resetAllToolStripMenuItem});
			this.tableContextMenuStrip.Location = new System.Drawing.Point(25, 108);
			this.tableContextMenuStrip.Name = "TableContextMenuStrip";
			this.tableContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tableContextMenuStrip.Size = new System.Drawing.Size(153, 67);
			this.tableContextMenuStrip.Visible = true;
			// 
			// viewResultsToolStripMenuItem1
			// 
			this.viewResultsToolStripMenuItem1.Image = AWEViewerCS.Properties.Resources.GoLtr;
			this.viewResultsToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewResultsToolStripMenuItem1.Name = "viewResultsToolStripMenuItem1";
			this.viewResultsToolStripMenuItem1.Text = "&View Results";
			this.viewResultsToolStripMenuItem1.Click += new System.EventHandler(this.viewResultsToolStripButton_Click);
			// 
			// resetAllToolStripMenuItem
			// 
			this.resetAllToolStripMenuItem.Image = AWEViewerCS.Properties.Resources.Restart;
			this.resetAllToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
			this.resetAllToolStripMenuItem.Text = "&Reset All";
			this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
			// 
			// optionsLabel
			// 
			this.optionsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.optionsLabel.AutoSize = true;
			this.optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optionsLabel.Location = new System.Drawing.Point(5, 2);
			this.optionsLabel.Name = "optionsLabel";
			this.optionsLabel.Size = new System.Drawing.Size(46, 13);
			this.optionsLabel.TabIndex = 0;
			this.optionsLabel.Text = "Options";
			// 
			// operatorsLabel
			// 
			this.operatorsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.operatorsLabel.AutoSize = true;
			this.operatorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.operatorsLabel.Location = new System.Drawing.Point(138, 2);
			this.operatorsLabel.Name = "operatorsLabel";
			this.operatorsLabel.Size = new System.Drawing.Size(58, 13);
			this.operatorsLabel.TabIndex = 1;
			this.operatorsLabel.Text = "Operators";
			// 
			// criteriaLabel
			// 
			this.criteriaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.criteriaLabel.AutoSize = true;
			this.criteriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.criteriaLabel.Location = new System.Drawing.Point(213, 2);
			this.criteriaLabel.Name = "criteriaLabel";
			this.criteriaLabel.Size = new System.Drawing.Size(43, 13);
			this.criteriaLabel.TabIndex = 2;
			this.criteriaLabel.Text = "Criteria";
			// 
			// sickLeaveRadioButton
			// 
			this.sickLeaveRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.sickLeaveRadioButton.AutoSize = true;
			this.sickLeaveRadioButton.Location = new System.Drawing.Point(5, 22);
			this.sickLeaveRadioButton.Name = "sickLeaveRadioButton";
			this.sickLeaveRadioButton.Size = new System.Drawing.Size(125, 17);
			this.sickLeaveRadioButton.TabIndex = 3;
			this.sickLeaveRadioButton.Text = "By Sick Leave (hours)";
			// 
			// sickLeaveComboBox
			// 
			this.sickLeaveComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.sickLeaveComboBox.FormattingEnabled = true;
			this.sickLeaveComboBox.Items.AddRange(new object[] {
            "<=",
            ">="});
			this.sickLeaveComboBox.Location = new System.Drawing.Point(138, 20);
			this.sickLeaveComboBox.Name = "sickLeaveComboBox";
			this.sickLeaveComboBox.Size = new System.Drawing.Size(67, 21);
			this.sickLeaveComboBox.TabIndex = 4;
			this.sickLeaveComboBox.Text = "<=";
			// 
			// sickLeaveNumericUpDown
			// 
			this.sickLeaveNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.sickLeaveNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.sickLeaveNumericUpDown.Location = new System.Drawing.Point(213, 20);
			this.sickLeaveNumericUpDown.Name = "sickLeaveNumericUpDown";
			this.sickLeaveNumericUpDown.Size = new System.Drawing.Size(41, 20);
			this.sickLeaveNumericUpDown.TabIndex = 5;
			// 
			// deptRadioButton
			// 
			this.deptRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.deptRadioButton.AutoSize = true;
			this.deptRadioButton.Location = new System.Drawing.Point(5, 147);
			this.deptRadioButton.Name = "deptRadioButton";
			this.deptRadioButton.Size = new System.Drawing.Size(91, 17);
			this.deptRadioButton.TabIndex = 8;
			this.deptRadioButton.Text = "By Department";
			// 
			// hireDateRadioButton
			// 
			this.hireDateRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.hireDateRadioButton.AutoSize = true;
			this.hireDateRadioButton.Location = new System.Drawing.Point(5, 284);
			this.hireDateRadioButton.Name = "hireDateRadioButton";
			this.hireDateRadioButton.Size = new System.Drawing.Size(81, 17);
			this.hireDateRadioButton.TabIndex = 10;
			this.hireDateRadioButton.Text = "By Hire Date";
			// 
			// hireDateComboBox
			// 
			this.hireDateComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.hireDateComboBox.FormattingEnabled = true;
			this.hireDateComboBox.Items.AddRange(new object[] {
            "<=",
            ">="});
			this.hireDateComboBox.Location = new System.Drawing.Point(138, 282);
			this.hireDateComboBox.Name = "hireDateComboBox";
			this.hireDateComboBox.Size = new System.Drawing.Size(67, 21);
			this.hireDateComboBox.TabIndex = 11;
			this.hireDateComboBox.Text = "<=";
			// 
			// hireDateMonthCalendar
			// 
			this.hireDateMonthCalendar.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.hireDateMonthCalendar.Location = new System.Drawing.Point(219, 215);
			this.hireDateMonthCalendar.Name = "hireDateMonthCalendar";
			this.hireDateMonthCalendar.Size = new System.Drawing.Size(178, 155);
			this.hireDateMonthCalendar.TabIndex = 12;
			// 
			// deptCheckedListBox
			// 
			this.deptCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.deptCheckedListBox.ContextMenuStrip = this.departmentContextMenuStrip;
			this.deptCheckedListBox.FormattingEnabled = true;
			this.deptCheckedListBox.Items.AddRange(new object[] {
            "Engineering",
            "Marketing",
            "Production",
            "Tool Design"});
			this.deptCheckedListBox.Location = new System.Drawing.Point(213, 120);
			this.deptCheckedListBox.Name = "deptCheckedListBox";
			this.deptCheckedListBox.Size = new System.Drawing.Size(105, 72);
			this.deptCheckedListBox.TabIndex = 9;
			// 
			// departmentContextMenuStrip
			// 
			this.departmentContextMenuStrip.Enabled = true;
			this.departmentContextMenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
			this.departmentContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.clearAllToolStripMenuItem});
			this.departmentContextMenuStrip.Location = new System.Drawing.Point(25, 108);
			this.departmentContextMenuStrip.Name = "DepartmentContextMenuStrip";
			this.departmentContextMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.departmentContextMenuStrip.Size = new System.Drawing.Size(114, 48);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Text = "&Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Text = "&Clear All";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// shiftListView
			// 
			this.shiftListView.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.shiftListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.shiftListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
			this.shiftListView.Location = new System.Drawing.Point(213, 49);
			this.shiftListView.Name = "shiftListView";
			this.shiftListView.Size = new System.Drawing.Size(166, 63);
			this.shiftListView.TabIndex = 7;
			this.shiftListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Shift";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Times";
			this.columnHeader2.Width = 100;
			// 
			// shiftRadioButton
			// 
			this.shiftRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.shiftRadioButton.AutoSize = true;
			this.shiftRadioButton.Location = new System.Drawing.Point(5, 72);
			this.shiftRadioButton.Name = "shiftRadioButton";
			this.shiftRadioButton.Size = new System.Drawing.Size(57, 17);
			this.shiftRadioButton.TabIndex = 6;
			this.shiftRadioButton.Text = "By Shift";
			// 
			// reportGeneratorMenuStrip
			// 
			this.reportGeneratorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.reportGeneratorMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.reportGeneratorMenuStrip.Name = "reportGeneratorMenuStrip";
			this.reportGeneratorMenuStrip.Size = new System.Drawing.Size(472, 24);
			this.reportGeneratorMenuStrip.TabIndex = 3;
			this.reportGeneratorMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewResultsToolStripMenuItem,
            this.toolStripSeparator1});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// ViewResultsToolStripMenuItem
			// 
			this.ViewResultsToolStripMenuItem.Image = AWEViewerCS.Properties.Resources.GoLtr;
			this.ViewResultsToolStripMenuItem.Name = "ViewResultsToolStripMenuItem";
			this.ViewResultsToolStripMenuItem.Text = "View &Results";
			this.ViewResultsToolStripMenuItem.Click += new System.EventHandler(this.viewResultsToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHelpToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Text = "&Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripButton_Click);
			// 
			// showHelpToolStripMenuItem
			// 
			this.showHelpToolStripMenuItem.Image = AWEViewerCS.Properties.Resources.Help;
			this.showHelpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.showHelpToolStripMenuItem.Name = "showHelpToolStripMenuItem";
			this.showHelpToolStripMenuItem.Text = "&Show Help";
			// 
			// ReportGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 483);
			this.Controls.Add(this.reportTableLayout);
			this.Controls.Add(this.reportLabel);
			this.Controls.Add(this.reportToolStrip);
			this.Controls.Add(this.reportGeneratorMenuStrip);
			this.MainMenuStrip = this.reportGeneratorMenuStrip;
			this.Name = "ReportGenerator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employees Report Generator";
			this.reportToolStrip.ResumeLayout(false);
			this.reportTableLayout.ResumeLayout(false);
			this.reportTableLayout.PerformLayout();
			this.tableContextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sickLeaveNumericUpDown)).EndInit();
			this.departmentContextMenuStrip.ResumeLayout(false);
			this.reportGeneratorMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		void help(object sender, System.EventArgs e)
		{
			throw new System.Exception("The method or operation is not implemented.");
		}

		#endregion

		private System.Windows.Forms.ToolStrip reportToolStrip;
		private System.Windows.Forms.Label reportLabel;
		private System.Windows.Forms.TableLayoutPanel reportTableLayout;
		private System.Windows.Forms.Label optionsLabel;
		private System.Windows.Forms.Label operatorsLabel;
		private System.Windows.Forms.Label criteriaLabel;
		private System.Windows.Forms.RadioButton sickLeaveRadioButton;
		private System.Windows.Forms.ComboBox sickLeaveComboBox;
		private System.Windows.Forms.NumericUpDown sickLeaveNumericUpDown;
		private System.Windows.Forms.RadioButton shiftRadioButton;
		private System.Windows.Forms.ListView shiftListView;
		private System.Windows.Forms.RadioButton deptRadioButton;
		private System.Windows.Forms.RadioButton hireDateRadioButton;
		private System.Windows.Forms.ComboBox hireDateComboBox;
		private System.Windows.Forms.MonthCalendar hireDateMonthCalendar;
		private System.Windows.Forms.CheckedListBox deptCheckedListBox;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.MenuStrip reportGeneratorMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip departmentContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip tableContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem viewResultsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton viewResultsToolStripButton;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem ViewResultsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showHelpToolStripMenuItem;
	}
}