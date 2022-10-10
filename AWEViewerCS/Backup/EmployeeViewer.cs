using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace AWEViewerCS
{
	public partial class EmployeeViewer : Form
	{
		public EmployeeViewer()
		{
			InitializeComponent();
		}

		private void getData()
		{
			XmlDocument Doc = new XmlDocument();
			try
			{
				// Load XML file contents into xmldocument object.
				Doc.Load(@"..\..\Supporting Files\Employees.xml");
				XmlNodeList Nodes = Doc.SelectNodes("Employees/Dept");
				// Loop through each dept node.
				foreach (XmlNode node in Nodes)
				{
					// New instance of EmployeeNode class.
					EmployeeNode tNode = new EmployeeNode();
					// Set properties of Dept node.
					tNode.ImageIndex = 0;
					tNode.SelectedImageIndex = 0;
					tNode.Text = node.Attributes.Item(0).Value;
					XmlNodeList nodes2 = node.SelectNodes("Employee");
					// Loop through each employee in department.
					foreach (XmlNode node2 in nodes2)
					{
						EmployeeNode tNode2 = new EmployeeNode();
						// Set properties of employee node.
						tNode2.ImageIndex = 1;
						tNode2.SelectedImageIndex = 2;
						tNode2.Text = node2.SelectSingleNode("Name").InnerText;
						tNode2.Img = node2.SelectSingleNode("Image").InnerText;
						tNode2.ID = node2.SelectSingleNode("ID").InnerText;
						// Add current employee node to nodes collection of Dept node.
						tNode.Nodes.Add(tNode2);
					}
					// Add Dept node to nodes collection of TreeView control.
					employeesTreeView.Nodes.Add(tNode);
				}}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}}

		private void loadDataToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Only load data if TreeView is currently empty.
				if (employeesTreeView.Nodes.Count == 0)
				{
					getData();
				}}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void clearDataToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (employeesTreeView.Nodes.Count != 0)
				{
					// Clear TreeView and remove image from PictureBox.
					employeesTreeView.Nodes.Clear();
				if (employeePictureBox.Image != null)
				{
					employeePictureBox.Image.Dispose();
					employeePictureBox.Image = null;
				}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

        private void employeesTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string photoDir = @"..\..\Photos\";
            string photoFileName;
            try
            {
                // Get the currently selected employee in the TreeView.
                EmployeeNode bNode = (EmployeeNode)employeesTreeView.SelectedNode;
                // Get the photo for the selected employee.
                if (!(bNode.Img == null))
                {
                    photoFileName = photoDir + bNode.Img;
                    if (!System.IO.File.Exists(photoFileName))
                    {
                        photoFileName = photoDir + "NA.bmp";
                    }
                }
                else
                {
                    photoFileName = photoDir + "NA.bmp";
                }
                // Load the selected photo into the PictureBox.
                employeePictureBox.Image = Image.FromFile(photoFileName);
                employeePictureBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}