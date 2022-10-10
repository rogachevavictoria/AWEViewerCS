using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWEViewerCS
{
	public partial class ReportGenerator : Form
	{
	// Private variables to store values selected on form.
	private string _selectedOption;
    private ArrayList _depts = new ArrayList();
    private string _shift;
    private System.DateTime _hireDate;
	private int _sickLeave;

		public ReportGenerator()
		{
			InitializeComponent();
		}

		// Public properties to get and set values stored in private variables.
		public string SelectedOption
		{
			get
			{
				return _selectedOption;
			}
			set
			{
				_selectedOption = value;
			}
		}
		public ArrayList Depts
		{
			get
			{
				return _depts;
			}
			set
			{
				_depts = value;
			}
		}
		public System.DateTime HireDate
		{
			get
			{
				return _hireDate;
			}
			set
			{
				_hireDate = value;
			}
		}
		public string Shift
		{
			get
			{
				return _shift;
			}
			set
			{
				_shift = value;
			}
		}
		public int SickLeave
		{
			get
			{
				return _sickLeave;
			}
			set
			{
				_sickLeave = value;
			}
		}

		private void viewResultsToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Initialize properties.
				Depts.Clear();
				HireDate = System.DateTime.MinValue;
				SickLeave = 0;
				Shift = "";
				SelectedOption = "";
				// Dept option selected.
				if (true == deptRadioButton.Checked)
				{
					// Set SelectedOption propert to Dept.
					this.SelectedOption = "Dept";
					// Store the selected departments.
					CheckedListBox.CheckedItemCollection clb = this.deptCheckedListBox.CheckedItems;
					if (clb.Count > 0)
					{
						// Initialize Depts ArrayList with empty strings.
						for (int z = 1; z <=4;z++)
						{
							Depts.Add("");
						}
						int x = 0;
						// Insert each selected department into Depts ArrayList.
						foreach (object itemChecked in deptCheckedListBox.CheckedItems)
						{
							Depts.Insert(x, itemChecked.ToString());
							x += 1;
						}
					}
					//// TODO Open EmployeeResultsGrid and pass selected departments.
					//// Store the selected options.
					//object[] Options = new object[5];
					//Options[0] = SelectedOption;
					//Options[1] = Depts[0];
					//Options[2] = Depts[1];
					//Options[3] = Depts[2];
					//Options[4] = Depts[3];
					//// Open EmployeeResultsGrid form and provide selected options.
					//EmployeeResultsGrid newEmployeeResultsGrid = new EmployeeResultsGrid();
					//newEmployeeResultsGrid.DisplayResults(Options);
					for (int I = 0; I <= clb.Count - 1; I++)
					{
						MessageBox.Show(this.SelectedOption + " " + Depts[I].ToString(), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				// HireDate option selected.
				else if (true == hireDateRadioButton.Checked)
				{
					// Set SelectedOption property to correct value.
					if (hireDateComboBox.Text == ">=")
					{
						this.SelectedOption = "HireGreaterThan";
					}
					else if (hireDateComboBox.Text == "<=")
					{
						this.SelectedOption = "HireLessThan";
					}
					// Set HireDate property to value selected in MonthCalendar.
					HireDate = hireDateMonthCalendar.SelectionStart;
					//// TODO Open EmployeeResultsGrid and pass selected hire date.
					//// Store the selected options.
					//object[] Options = new object[2];
					//Options[0] = SelectedOption;
					//Options[1] = HireDate;
					//// Open EmployeeResultsGrid form and provide selected options.
					//EmployeeResultsGrid newEmployeeResultsGrid = new EmployeeResultsGrid();
					//newEmployeeResultsGrid.DisplayResults(Options);
					MessageBox.Show(this.SelectedOption + " " + HireDate.ToString(), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				// Shift option selected.
				else if (true == shiftRadioButton.Checked)
				{
					// Set SelectedOption property to Shift.
					this.SelectedOption = "Shift";
					// Set Shift property to the selected shift.
					ListView.SelectedListViewItemCollection lv = this.shiftListView.SelectedItems;
					if (lv.Count > 0)
					{
						foreach (ListViewItem Item in lv)
						{
							Shift = Item.SubItems[0].Text;
						}
					}

					// TODO Open EmployeeResultsGrid and pass selected shift.

					MessageBox.Show(this.SelectedOption + " " + Shift, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				// SickLeave option selected.
				else if (true == sickLeaveRadioButton.Checked)
				{
					// Set SelectedOption property to appropriate value.
					if (sickLeaveComboBox.Text == ">=")
					{
						this.SelectedOption = "SickGreaterThan";
					}
					else if (sickLeaveComboBox.Text == "<=")
					{
						this.SelectedOption = "SickLessThan";
					}
					// Set SickLeave property to value selected in NumericUpDown control.
					SickLeave = (int)sickLeaveNumericUpDown.Value;

					// TODO Open EmployeeResultsGrid and pass selected sick leave.

					MessageBox.Show(this.SelectedOption + " " + SickLeave.ToString(), "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void helpToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Open the ReportGeneratorHelp form.
				Form newReportHelp = new ReportGeneratorHelp();
				newReportHelp.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Select all items in DeptCheckedListBox.
			for (int i = 0; i < deptCheckedListBox.Items.Count; i++)
			{
				deptCheckedListBox.SetItemCheckState(i, CheckState.Checked);
			}
		}

		private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Clear all items in DeptCheckedListBox.
			for (int i = 0; i < deptCheckedListBox.Items.Count; i++)
			{
				deptCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
			}
		}

		private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Reset all controls on form.
			sickLeaveRadioButton.Checked = true;
			sickLeaveComboBox.Text = "<=";
			sickLeaveNumericUpDown.Value = 0;
			shiftRadioButton.Checked = false;
			shiftListView.SelectedItems.Clear();
			deptRadioButton.Checked = false;
			for (int i = 0; i < deptCheckedListBox.Items.Count; i++)
			{
				deptCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
			}
			hireDateRadioButton.Checked = false;
			hireDateComboBox.Text = "<=";
			hireDateMonthCalendar.SetSelectionRange(DateTime.Today, DateTime.Today);
		}
	}
}