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
    public partial class StudentForm : Form
    {
        DataBaseCore core;

        public StudentForm(DataBaseCore dataBaseCore)
        {
            core = dataBaseCore;
            InitializeComponent();
            groupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            studentView.DataSource = core.TakeAllStudents();
            List<string> groupNames = core.GetGroupNames();
            for (int i = 0; i < groupNames.Count; i++)
            {
                groupComboBox.Items.Add(groupNames[i]);
            }
            studentView.Columns[5].Visible = false;
        }


        private void addButton_Click_1(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || ageTextBox.Text == "" || (groupComboBox.SelectedItem == null && groupIdTextBox.Text == ""))
                MessageBox.Show("Not enough data!");
            else
            {

                if (Checker.IntCheck(ageTextBox.Text))
                {
                    if (groupIdTextBox.Text != "")
                    {
                        try
                        {
                            core.AddStudentWithGroupId(nameTextBox.Text, Convert.ToInt32(groupIdTextBox.Text), ageTextBox.Text);
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
                            core.AddStudentWithGroupName(nameTextBox.Text, groupComboBox.Text, ageTextBox.Text);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Such a group not found!");
                        }
                    }
                }
            }
        }

        

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (changeList.CheckedItems.Contains(changeList.Items[0]))
                NewName();
            if (changeList.CheckedItems.Contains(changeList.Items[1]))
                NewAge();
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
            studentView.Refresh();
        }

        private void NewName()
        {
            if (Checker.CheckRows(studentView))
                if (nameTextBox.Text != "")
                    for (int i = 0; i < studentView.SelectedRows.Count; i++)
                        core.UpdateStudentName(nameTextBox.Text, studentView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    MessageBox.Show("Write new name!");
        }

        private void NewAge()
        {
            if (Checker.CheckRows(studentView))
                if (Checker.IntCheck(ageTextBox.Text))
                    for (int i = 0; i < studentView.SelectedRows.Count; i++)
                        core.UpdateStudentAge(ageTextBox.Text, studentView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    MessageBox.Show("Age must be integer!");
        }

        private void NewGroup()
        {
            if (Checker.CheckRows(studentView))
                if (groupIdTextBox.Text == "")
                    for (int i = 0; i < studentView.SelectedRows.Count; i++)
                        core.UpdateStudentGroupWithName(groupComboBox.Text, studentView.SelectedRows[i].Cells[0].Value.ToString());
                else
                    if (Checker.IntCheck(groupIdTextBox.Text))
                        for (int i = 0; i < studentView.SelectedRows.Count; i++)
                            core.UpdateStudentGroupWithId(Convert.ToInt32(groupIdTextBox.Text), studentView.SelectedRows[i].Cells[0].Value.ToString());
                    else
                        MessageBox.Show("Group id must be integer!");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (Checker.CheckRows(studentView))
            {
                for (int i = 0; i < studentView.SelectedRows.Count; i++)
                    core.DeleteStudent(studentView.SelectedRows[i].Cells[0].Value.ToString());
            }
        }

        private void findCuratorButton_Click(object sender, EventArgs e)
        {
            if (Checker.CheckRows(studentView))
                curatorNameTextBox.Text = core.FindCuratorsName(Convert.ToInt32(studentView.SelectedRows[0].Cells[2].Value.ToString()));
        }
    }
}
