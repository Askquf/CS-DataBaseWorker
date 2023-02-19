
namespace Presentation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.studentButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.curetorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentButton
            // 
            this.studentButton.Location = new System.Drawing.Point(12, 12);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(210, 121);
            this.studentButton.TabIndex = 1;
            this.studentButton.Text = "Working with students";
            this.studentButton.UseVisualStyleBackColor = true;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(228, 12);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(210, 121);
            this.groupButton.TabIndex = 1;
            this.groupButton.Text = "Working with groups";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // curetorButton
            // 
            this.curetorButton.Location = new System.Drawing.Point(444, 12);
            this.curetorButton.Name = "curetorButton";
            this.curetorButton.Size = new System.Drawing.Size(210, 121);
            this.curetorButton.TabIndex = 1;
            this.curetorButton.Text = "Working with curators";
            this.curetorButton.UseVisualStyleBackColor = true;
            this.curetorButton.Click += new System.EventHandler(this.curatorButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 472);
            this.Controls.Add(this.curetorButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.studentButton);
            this.Name = "MainForm";
            this.Text = "Date Base Worker";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button curetorButton;
    }
}

