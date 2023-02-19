using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Core;

namespace Presentation
{
    public partial class CuratorForm : Form
    {
        DataBaseCore core;
        public CuratorForm(DataBaseCore dataBaseCore)
        {
            core = dataBaseCore;
            InitializeComponent();
            groupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            curatorView.DataSource = core.TakeAllCurators();
            List<string> groupNames = core.GetGroupNames();
            for (int i = 0; i < groupNames.Count; i++)
            {
                groupComboBox.Items.Add(groupNames[i]);
            }
            curatorView.Columns[5].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || emailTextBox.Text == "" || (groupComboBox.SelectedItem == null && groupIdTextBox.Text == ""))
                MessageBox.Show("Not enough data!");
            else
            {
                if (groupIdTextBox.Text != "")
                {
                    try
                    {
                        core.AddCuratorWithGroupId(nameTextBox.Text, Convert.ToInt32(groupIdTextBox.Text), emailTextBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Such a group not found!");
                    }
                }
                else
                {
                    try
                    {
                        core.AddCuratorWithGroupName(nameTextBox.Text, groupComboBox.Text, emailTextBox.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Such a group not found!");
                    }
                }
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (changeList.CheckedItems.Contains(changeList.Items[0]))
                NewName();
            if (changeList.CheckedItems.Contains(changeList.Items[1]))
                NewEmail();
            if (changeList.CheckedItems.Contains(changeList.Items[2]))
            {
                try
                {
                    NewGroup();
                }
                catch (Exception)
                {
                    MessageBox.Show("Such a group not found!");
                }
            }
            if (changeList.CheckedItems.Count == 0)
                MessageBox.Show("Choose parametrs to change!");
            curatorView.Refresh();
        }

        private void NewName()
        {
            if (Checker.CheckRows(curatorView))
                if (nameTextBox.Text != "")
                    for (int i = 0; i < curatorView.SelectedRows.Count; i++)
                        core.UpdateCuratorName(nameTextBox.Text, curatorView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    MessageBox.Show("Write new name!");
        }

        private void NewEmail()
        {
            if (Checker.CheckRows(curatorView))
                if (emailTextBox.Text != "")
                    for (int i = 0; i < curatorView.SelectedRows.Count; i++)
                        core.UpdateCuratorEmail(emailTextBox.Text, curatorView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    MessageBox.Show("Write new email!");
        }

        private void NewGroup()
        {
            if (Checker.CheckRows(curatorView))
                if (groupIdTextBox.Text == "")
                    for (int i = 0; i < curatorView.SelectedRows.Count; i++)
                        core.UpdateCuratorGroupWithName(groupComboBox.Text, curatorView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    if (Checker.IntCheck(groupIdTextBox.Text))
                    for (int i = 0; i < curatorView.SelectedRows.Count; i++)
                        core.UpdateCuratorGroupWithId(Convert.ToInt32(groupIdTextBox.Text), curatorView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    MessageBox.Show("Group id must be integer!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Checker.CheckRows(curatorView))
            {
                for (int i = 0; i < curatorView.SelectedRows.Count; i++)
                    core.DeleteCurator(curatorView.SelectedRows[i].Cells[0].Value.ToString());
            }
        }

        private void countAverageButton_Click(object sender, EventArgs e)
        {
            if (Checker.CheckRows(curatorView))
                averageAgeTextBox.Text = core.CountAverageAge(Convert.ToInt32(curatorView.SelectedRows[0].Cells[1].Value.ToString())).ToString();
        }
    }
}
