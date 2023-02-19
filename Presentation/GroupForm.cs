using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core;
//using DatabaseModels;


namespace Presentation
{
    public partial class GroupForm : Form
    {
        DataBaseCore core;

        public GroupForm(DataBaseCore dataBaseCore)
        {
            InitializeComponent();
            core = dataBaseCore;
            GroupView.DataSource = core.TakeAllGroups();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
                MessageBox.Show("Print name of the group!");
            else
                core.AddGroup(nameTextBox.Text, dateTimePicker.Value);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (changeList.CheckedItems.Contains(changeList.Items[0]))
                NewName();
            if (changeList.CheckedItems.Contains(changeList.Items[1]))
                NewTime();
            if (changeList.CheckedItems.Count == 0)
                MessageBox.Show("Choose parametrs to change!");
            GroupView.Refresh();
        }

        private void NewName()
        {
            if (Checker.CheckRows(GroupView))
                if (nameTextBox.Text != "")
                    for (int i = 0; i < GroupView.SelectedRows.Count; i++)
                        core.UpdateGroupName(nameTextBox.Text, GroupView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    MessageBox.Show("Write new name!");
        }

        private void NewTime()
        {
            if (Checker.CheckRows(GroupView))
                for (int i = 0; i < GroupView.SelectedRows.Count; i++)
                    core.UpdateGroupTime(dateTimePicker.Value, GroupView.SelectedRows[i].Cells[0].Value.ToString());
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Checker.CheckRows(GroupView))
            {
                for (int i = 0; i < GroupView.SelectedRows.Count; i++)
                    core.DeleteGroup(GroupView.SelectedRows[i].Cells[0].Value.ToString());
            }
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            if (Checker.CheckRows(GroupView))
                countTextBox.Text = core.CountAll(Convert.ToInt32(GroupView.SelectedRows[0].Cells[0].Value.ToString())).ToString();
        }
    }
}
