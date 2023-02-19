
namespace Presentation
{
    partial class CuratorForm
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
            this.curatorView = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeList = new System.Windows.Forms.CheckedListBox();
            this.groupIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.countAverageButton = new System.Windows.Forms.Button();
            this.averageAgeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.curatorView)).BeginInit();
            this.SuspendLayout();
            // 
            // curatorView
            // 
            this.curatorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.curatorView.Location = new System.Drawing.Point(302, 32);
            this.curatorView.Name = "curatorView";
            this.curatorView.ReadOnly = true;
            this.curatorView.RowHeadersWidth = 62;
            this.curatorView.RowTemplate.Height = 33;
            this.curatorView.Size = new System.Drawing.Size(486, 390);
            this.curatorView.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(13, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(274, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 105);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(274, 31);
            this.emailTextBox.TabIndex = 2;
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(12, 175);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(182, 33);
            this.groupComboBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(2, 294);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 50);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(99, 294);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(101, 50);
            this.changeButton.TabIndex = 5;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(206, 294);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(81, 50);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeList
            // 
            this.changeList.FormattingEnabled = true;
            this.changeList.Items.AddRange(new object[] {
            "Name",
            "Email",
            "Group"});
            this.changeList.Location = new System.Drawing.Point(99, 350);
            this.changeList.Name = "changeList";
            this.changeList.Size = new System.Drawing.Size(101, 88);
            this.changeList.TabIndex = 7;
            // 
            // groupIdTextBox
            // 
            this.groupIdTextBox.Location = new System.Drawing.Point(12, 257);
            this.groupIdTextBox.Name = "groupIdTextBox";
            this.groupIdTextBox.Size = new System.Drawing.Size(150, 31);
            this.groupIdTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Group";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group id (if nes.)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Average age of che chosen curator:";
            // 
            // countAverageButton
            // 
            this.countAverageButton.Location = new System.Drawing.Point(302, 476);
            this.countAverageButton.Name = "countAverageButton";
            this.countAverageButton.Size = new System.Drawing.Size(112, 34);
            this.countAverageButton.TabIndex = 11;
            this.countAverageButton.Text = "Count!";
            this.countAverageButton.UseVisualStyleBackColor = true;
            this.countAverageButton.Click += new System.EventHandler(this.countAverageButton_Click);
            // 
            // averageAgeTextBox
            // 
            this.averageAgeTextBox.Location = new System.Drawing.Point(16, 480);
            this.averageAgeTextBox.Name = "averageAgeTextBox";
            this.averageAgeTextBox.ReadOnly = true;
            this.averageAgeTextBox.Size = new System.Drawing.Size(195, 31);
            this.averageAgeTextBox.TabIndex = 12;
            // 
            // CuratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.averageAgeTextBox);
            this.Controls.Add(this.countAverageButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupIdTextBox);
            this.Controls.Add(this.changeList);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.curatorView);
            this.Name = "CuratorForm";
            this.Text = "CuratorForm";
            ((System.ComponentModel.ISupportInitialize)(this.curatorView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DataGridView curatorView;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.CheckedListBox changeList;
        private System.Windows.Forms.TextBox groupIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button countAverageButton;
        private System.Windows.Forms.TextBox averageAgeTextBox;
    }
    #region Windows Form Designer generated code



        #endregion
    
}
