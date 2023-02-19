using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using DatabaseContext;
using System.Threading;
using Core;

namespace Presentation
{
    public partial class MainForm : Form
    {
        Thread studentThread;
        Thread groupThread;
        Thread curatorThread;
        DataBaseCore core;

        public bool studentClicked { get; set; }
        public bool groupClicked { get; set; }
        public bool curatorClicked { get; set; }
        

        public MainForm()
        {
            InitializeComponent();
            curatorClicked = false;
            groupClicked = false;
            studentClicked = false;
            core = new DataBaseCore();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {   
            if (studentClicked == false)
            {
                studentClicked = true;
                studentThread = new Thread(RunStudentForm);
                studentThread.Start();
            }
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            if (groupClicked == false)
            {
                groupClicked = true;
                groupThread = new Thread(RunGroupForm);
                groupThread.Start();
            }
        }

        private void curatorButton_Click(object sender, EventArgs e)
        {
            if (curatorClicked == false)
            {
                curatorClicked = true;
                curatorThread = new Thread(RunCuratorForm);
                curatorThread.Start();
            }
        }

        private void RunStudentForm()
        {
            StudentForm stForm = new StudentForm(core);
            stForm.Closing += new CancelEventHandler(ChangeStudentClicked);
            Application.Run(stForm);
        }

        private void RunGroupForm()
        {
            GroupForm grForm = new GroupForm(core);
            grForm.Closing += new CancelEventHandler(ChangeGroupClicked);
            Application.Run(grForm);
        }

        private void RunCuratorForm()
        {
            CuratorForm curatorForm = new CuratorForm(core);
            curatorForm.Closing += new CancelEventHandler(ChangeCuratorClicked);
            Application.Run(curatorForm); 
        }

        public void ChangeStudentClicked(object sender, CancelEventArgs e)
        {
            studentClicked = false;
        }

        public void ChangeGroupClicked(object sender, CancelEventArgs e)
        {
            groupClicked = false;
        }

        public void ChangeCuratorClicked(object sender, CancelEventArgs e)
        {
            curatorClicked = false;
        }
    }
}
