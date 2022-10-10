namespace AWEViewerCS
{
    partial class EmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label birth_DateLabel;
            System.Windows.Forms.Label addressLine1Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label postal_CodeLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label job_TitleLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label department_GroupLabel;
            System.Windows.Forms.Label shiftLabel;
            System.Windows.Forms.Label hire_DateLabel;
            System.Windows.Forms.Label sick_LeaveLabel;
            this.employeeDetailsTabControl = new System.Windows.Forms.TabControl();
            this.employeeInfoTabPage = new System.Windows.Forms.TabPage();
            this.employeeDetailsDataSet = new AWEViewerCS.EmployeeDetailsDataSet();
            this.vEmployeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEmployeeDetailsTableAdapter = new AWEViewerCS.EmployeeDetailsDataSetTableAdapters.vEmployeeDetailsTableAdapter();
            this.tableAdapterManager = new AWEViewerCS.EmployeeDetailsDataSetTableAdapters.TableAdapterManager();
            this.vEmployeeDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.birth_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTabPage = new System.Windows.Forms.TabPage();
            this.addressLine1TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.postal_CodeTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.employmentTabPage = new System.Windows.Forms.TabPage();
            this.job_TitleTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.department_GroupTextBox = new System.Windows.Forms.TextBox();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.hire_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sick_LeaveTextBox = new System.Windows.Forms.TextBox();
            this.closeToolStripButton = new System.Windows.Forms.ToolStripButton();
            titleLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            birth_DateLabel = new System.Windows.Forms.Label();
            addressLine1Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            postal_CodeLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            job_TitleLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            department_GroupLabel = new System.Windows.Forms.Label();
            shiftLabel = new System.Windows.Forms.Label();
            hire_DateLabel = new System.Windows.Forms.Label();
            sick_LeaveLabel = new System.Windows.Forms.Label();
            this.employeeDetailsTabControl.SuspendLayout();
            this.employeeInfoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailsBindingNavigator)).BeginInit();
            this.vEmployeeDetailsBindingNavigator.SuspendLayout();
            this.addressTabPage.SuspendLayout();
            this.employmentTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeDetailsTabControl
            // 
            this.employeeDetailsTabControl.Controls.Add(this.employeeInfoTabPage);
            this.employeeDetailsTabControl.Controls.Add(this.addressTabPage);
            this.employeeDetailsTabControl.Controls.Add(this.employmentTabPage);
            this.employeeDetailsTabControl.Location = new System.Drawing.Point(25, 50);
            this.employeeDetailsTabControl.Name = "employeeDetailsTabControl";
            this.employeeDetailsTabControl.SelectedIndex = 0;
            this.employeeDetailsTabControl.Size = new System.Drawing.Size(445, 330);
            this.employeeDetailsTabControl.TabIndex = 0;
            // 
            // employeeInfoTabPage
            // 
            this.employeeInfoTabPage.Controls.Add(birth_DateLabel);
            this.employeeInfoTabPage.Controls.Add(this.birth_DateDateTimePicker);
            this.employeeInfoTabPage.Controls.Add(phoneLabel);
            this.employeeInfoTabPage.Controls.Add(this.phoneTextBox);
            this.employeeInfoTabPage.Controls.Add(emailLabel);
            this.employeeInfoTabPage.Controls.Add(this.emailTextBox);
            this.employeeInfoTabPage.Controls.Add(last_NameLabel);
            this.employeeInfoTabPage.Controls.Add(this.last_NameTextBox);
            this.employeeInfoTabPage.Controls.Add(first_NameLabel);
            this.employeeInfoTabPage.Controls.Add(this.first_NameTextBox);
            this.employeeInfoTabPage.Controls.Add(titleLabel);
            this.employeeInfoTabPage.Controls.Add(this.titleTextBox);
            this.employeeInfoTabPage.Location = new System.Drawing.Point(4, 25);
            this.employeeInfoTabPage.Name = "employeeInfoTabPage";
            this.employeeInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeeInfoTabPage.Size = new System.Drawing.Size(437, 301);
            this.employeeInfoTabPage.TabIndex = 0;
            this.employeeInfoTabPage.Text = "Employee Information";
            this.employeeInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // employeeDetailsDataSet
            // 
            this.employeeDetailsDataSet.DataSetName = "EmployeeDetailsDataSet";
            this.employeeDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEmployeeDetailsBindingSource
            // 
            this.vEmployeeDetailsBindingSource.DataMember = "vEmployeeDetails";
            this.vEmployeeDetailsBindingSource.DataSource = this.employeeDetailsDataSet;
            // 
            // vEmployeeDetailsTableAdapter
            // 
            this.vEmployeeDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = AWEViewerCS.EmployeeDetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vEmployeeDetailsBindingNavigator
            // 
            this.vEmployeeDetailsBindingNavigator.AddNewItem = null;
            this.vEmployeeDetailsBindingNavigator.BindingSource = this.vEmployeeDetailsBindingSource;
            this.vEmployeeDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vEmployeeDetailsBindingNavigator.DeleteItem = null;
            this.vEmployeeDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vEmployeeDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.closeToolStripButton});
            this.vEmployeeDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vEmployeeDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vEmployeeDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vEmployeeDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vEmployeeDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vEmployeeDetailsBindingNavigator.Name = "vEmployeeDetailsBindingNavigator";
            this.vEmployeeDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vEmployeeDetailsBindingNavigator.Size = new System.Drawing.Size(492, 27);
            this.vEmployeeDetailsBindingNavigator.TabIndex = 1;
            this.vEmployeeDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(51, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(40, 22);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(6, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(39, 17);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "First Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(92, 45);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.first_NameTextBox.TabIndex = 3;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(6, 48);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(80, 17);
            first_NameLabel.TabIndex = 2;
            first_NameLabel.Text = "First Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Last Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(92, 76);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(200, 22);
            this.last_NameTextBox.TabIndex = 5;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(6, 79);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(80, 17);
            last_NameLabel.TabIndex = 4;
            last_NameLabel.Text = "Last Name:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(58, 108);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(6, 111);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(65, 139);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 9;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(6, 142);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 8;
            phoneLabel.Text = "Phone:";
            // 
            // birth_DateDateTimePicker
            // 
            this.birth_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vEmployeeDetailsBindingSource, "Birth Date", true));
            this.birth_DateDateTimePicker.Location = new System.Drawing.Point(92, 174);
            this.birth_DateDateTimePicker.Name = "birth_DateDateTimePicker";
            this.birth_DateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birth_DateDateTimePicker.TabIndex = 11;
            // 
            // birth_DateLabel
            // 
            birth_DateLabel.AutoSize = true;
            birth_DateLabel.Location = new System.Drawing.Point(11, 178);
            birth_DateLabel.Name = "birth_DateLabel";
            birth_DateLabel.Size = new System.Drawing.Size(75, 17);
            birth_DateLabel.TabIndex = 10;
            birth_DateLabel.Text = "Birth Date:";
            // 
            // addressTabPage
            // 
            this.addressTabPage.Controls.Add(countryLabel);
            this.addressTabPage.Controls.Add(this.countryTextBox);
            this.addressTabPage.Controls.Add(stateLabel);
            this.addressTabPage.Controls.Add(this.stateTextBox);
            this.addressTabPage.Controls.Add(postal_CodeLabel);
            this.addressTabPage.Controls.Add(this.postal_CodeTextBox);
            this.addressTabPage.Controls.Add(cityLabel);
            this.addressTabPage.Controls.Add(this.cityTextBox);
            this.addressTabPage.Controls.Add(addressLine1Label);
            this.addressTabPage.Controls.Add(this.addressLine1TextBox);
            this.addressTabPage.Location = new System.Drawing.Point(4, 25);
            this.addressTabPage.Name = "addressTabPage";
            this.addressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addressTabPage.Size = new System.Drawing.Size(437, 301);
            this.addressTabPage.TabIndex = 1;
            this.addressTabPage.Text = "Address Details";
            this.addressTabPage.UseVisualStyleBackColor = true;
            // 
            // addressLine1Label
            // 
            addressLine1Label.AutoSize = true;
            addressLine1Label.Location = new System.Drawing.Point(6, 12);
            addressLine1Label.Name = "addressLine1Label";
            addressLine1Label.Size = new System.Drawing.Size(103, 17);
            addressLine1Label.TabIndex = 0;
            addressLine1Label.Text = "Address Line1:";
            // 
            // addressLine1TextBox
            // 
            this.addressLine1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "AddressLine1", true));
            this.addressLine1TextBox.Location = new System.Drawing.Point(115, 9);
            this.addressLine1TextBox.Name = "addressLine1TextBox";
            this.addressLine1TextBox.Size = new System.Drawing.Size(150, 22);
            this.addressLine1TextBox.TabIndex = 1;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(6, 44);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(47, 41);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(150, 22);
            this.cityTextBox.TabIndex = 3;
            // 
            // postal_CodeLabel
            // 
            postal_CodeLabel.AutoSize = true;
            postal_CodeLabel.Location = new System.Drawing.Point(6, 77);
            postal_CodeLabel.Name = "postal_CodeLabel";
            postal_CodeLabel.Size = new System.Drawing.Size(88, 17);
            postal_CodeLabel.TabIndex = 4;
            postal_CodeLabel.Text = "Postal Code:";
            // 
            // postal_CodeTextBox
            // 
            this.postal_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Postal Code", true));
            this.postal_CodeTextBox.Location = new System.Drawing.Point(100, 74);
            this.postal_CodeTextBox.Name = "postal_CodeTextBox";
            this.postal_CodeTextBox.Size = new System.Drawing.Size(150, 22);
            this.postal_CodeTextBox.TabIndex = 5;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(6, 110);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 6;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(57, 107);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(150, 22);
            this.stateTextBox.TabIndex = 7;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(6, 141);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 8;
            countryLabel.Text = "Country:";
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(73, 138);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(150, 22);
            this.countryTextBox.TabIndex = 9;
            // 
            // employmentTabPage
            // 
            this.employmentTabPage.Controls.Add(sick_LeaveLabel);
            this.employmentTabPage.Controls.Add(this.sick_LeaveTextBox);
            this.employmentTabPage.Controls.Add(hire_DateLabel);
            this.employmentTabPage.Controls.Add(this.hire_DateDateTimePicker);
            this.employmentTabPage.Controls.Add(shiftLabel);
            this.employmentTabPage.Controls.Add(this.shiftTextBox);
            this.employmentTabPage.Controls.Add(department_GroupLabel);
            this.employmentTabPage.Controls.Add(this.department_GroupTextBox);
            this.employmentTabPage.Controls.Add(departmentLabel);
            this.employmentTabPage.Controls.Add(this.departmentTextBox);
            this.employmentTabPage.Controls.Add(job_TitleLabel);
            this.employmentTabPage.Controls.Add(this.job_TitleTextBox);
            this.employmentTabPage.Location = new System.Drawing.Point(4, 25);
            this.employmentTabPage.Name = "employmentTabPage";
            this.employmentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employmentTabPage.Size = new System.Drawing.Size(437, 301);
            this.employmentTabPage.TabIndex = 2;
            this.employmentTabPage.Text = "Employment Details";
            this.employmentTabPage.UseVisualStyleBackColor = true;
            // 
            // job_TitleLabel
            // 
            job_TitleLabel.AutoSize = true;
            job_TitleLabel.Location = new System.Drawing.Point(6, 14);
            job_TitleLabel.Name = "job_TitleLabel";
            job_TitleLabel.Size = new System.Drawing.Size(66, 17);
            job_TitleLabel.TabIndex = 0;
            job_TitleLabel.Text = "Job Title:";
            // 
            // job_TitleTextBox
            // 
            this.job_TitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Job Title", true));
            this.job_TitleTextBox.Location = new System.Drawing.Point(78, 11);
            this.job_TitleTextBox.Name = "job_TitleTextBox";
            this.job_TitleTextBox.Size = new System.Drawing.Size(200, 22);
            this.job_TitleTextBox.TabIndex = 1;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(6, 46);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(86, 17);
            departmentLabel.TabIndex = 2;
            departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(98, 43);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(200, 22);
            this.departmentTextBox.TabIndex = 3;
            // 
            // department_GroupLabel
            // 
            department_GroupLabel.AutoSize = true;
            department_GroupLabel.Location = new System.Drawing.Point(6, 78);
            department_GroupLabel.Name = "department_GroupLabel";
            department_GroupLabel.Size = new System.Drawing.Size(130, 17);
            department_GroupLabel.TabIndex = 4;
            department_GroupLabel.Text = "Department Group:";
            // 
            // department_GroupTextBox
            // 
            this.department_GroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Department Group", true));
            this.department_GroupTextBox.Location = new System.Drawing.Point(142, 75);
            this.department_GroupTextBox.Name = "department_GroupTextBox";
            this.department_GroupTextBox.Size = new System.Drawing.Size(200, 22);
            this.department_GroupTextBox.TabIndex = 5;
            // 
            // shiftLabel
            // 
            shiftLabel.AutoSize = true;
            shiftLabel.Location = new System.Drawing.Point(6, 114);
            shiftLabel.Name = "shiftLabel";
            shiftLabel.Size = new System.Drawing.Size(40, 17);
            shiftLabel.TabIndex = 6;
            shiftLabel.Text = "Shift:";
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Shift", true));
            this.shiftTextBox.Location = new System.Drawing.Point(52, 111);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(200, 22);
            this.shiftTextBox.TabIndex = 7;
            // 
            // hire_DateLabel
            // 
            hire_DateLabel.AutoSize = true;
            hire_DateLabel.Location = new System.Drawing.Point(6, 147);
            hire_DateLabel.Name = "hire_DateLabel";
            hire_DateLabel.Size = new System.Drawing.Size(72, 17);
            hire_DateLabel.TabIndex = 8;
            hire_DateLabel.Text = "Hire Date:";
            // 
            // hire_DateDateTimePicker
            // 
            this.hire_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vEmployeeDetailsBindingSource, "Hire Date", true));
            this.hire_DateDateTimePicker.Location = new System.Drawing.Point(84, 143);
            this.hire_DateDateTimePicker.Name = "hire_DateDateTimePicker";
            this.hire_DateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.hire_DateDateTimePicker.TabIndex = 9;
            // 
            // sick_LeaveLabel
            // 
            sick_LeaveLabel.AutoSize = true;
            sick_LeaveLabel.Location = new System.Drawing.Point(6, 180);
            sick_LeaveLabel.Name = "sick_LeaveLabel";
            sick_LeaveLabel.Size = new System.Drawing.Size(81, 17);
            sick_LeaveLabel.TabIndex = 10;
            sick_LeaveLabel.Text = "Sick Leave:";
            // 
            // sick_LeaveTextBox
            // 
            this.sick_LeaveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vEmployeeDetailsBindingSource, "Sick Leave", true));
            this.sick_LeaveTextBox.Location = new System.Drawing.Point(93, 177);
            this.sick_LeaveTextBox.Name = "sick_LeaveTextBox";
            this.sick_LeaveTextBox.Size = new System.Drawing.Size(200, 22);
            this.sick_LeaveTextBox.TabIndex = 11;
            // 
            // closeToolStripButton
            // 
            this.closeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.closeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripButton.Image")));
            this.closeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeToolStripButton.Name = "closeToolStripButton";
            this.closeToolStripButton.Size = new System.Drawing.Size(87, 24);
            this.closeToolStripButton.Text = "Close Form";
            this.closeToolStripButton.Click += new System.EventHandler(this.closeToolStripButton_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 383);
            this.Controls.Add(this.vEmployeeDetailsBindingNavigator);
            this.Controls.Add(this.employeeDetailsTabControl);
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.employeeDetailsTabControl.ResumeLayout(false);
            this.employeeInfoTabPage.ResumeLayout(false);
            this.employeeInfoTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEmployeeDetailsBindingNavigator)).EndInit();
            this.vEmployeeDetailsBindingNavigator.ResumeLayout(false);
            this.vEmployeeDetailsBindingNavigator.PerformLayout();
            this.addressTabPage.ResumeLayout(false);
            this.addressTabPage.PerformLayout();
            this.employmentTabPage.ResumeLayout(false);
            this.employmentTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl employeeDetailsTabControl;
        private System.Windows.Forms.TabPage employeeInfoTabPage;
        private EmployeeDetailsDataSet employeeDetailsDataSet;
        private System.Windows.Forms.BindingSource vEmployeeDetailsBindingSource;
        private EmployeeDetailsDataSetTableAdapters.vEmployeeDetailsTableAdapter vEmployeeDetailsTableAdapter;
        private EmployeeDetailsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vEmployeeDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker birth_DateDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TabPage addressTabPage;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox postal_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox addressLine1TextBox;
        private System.Windows.Forms.TabPage employmentTabPage;
        private System.Windows.Forms.TextBox sick_LeaveTextBox;
        private System.Windows.Forms.DateTimePicker hire_DateDateTimePicker;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.TextBox department_GroupTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox job_TitleTextBox;
        private System.Windows.Forms.ToolStripButton closeToolStripButton;
    }
}