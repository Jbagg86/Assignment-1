
namespace Assignment_1
{
    partial class Form1
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblHoursWorked = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtHoursWorked = new TextBox();
            btnSummarize = new Button();
            btnClear = new Button();
            txtSummary = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(68, 82);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "&First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(349, 87);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "&Last Name";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(604, 83);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(83, 15);
            lblHoursWorked.TabIndex = 4;
            lblHoursWorked.Text = "&Hours Worked";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(68, 105);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(349, 105);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(604, 101);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 5;
            txtHoursWorked.TextChanged += txtHoursWorked_TextChanged;
            // 
            // btnSummarize
            // 
            btnSummarize.Location = new Point(68, 203);
            btnSummarize.Name = "btnSummarize";
            btnSummarize.Size = new Size(75, 23);
            btnSummarize.TabIndex = 6;
            btnSummarize.Text = "&Summarize";
            btnSummarize.UseVisualStyleBackColor = true;
            btnSummarize.Click += btnSummarize_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(172, 203);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtSummary
            // 
            txtSummary.BorderStyle = BorderStyle.FixedSingle;
            txtSummary.Location = new Point(68, 310);
            txtSummary.Name = "txtSummary";
            txtSummary.Size = new Size(630, 100);
            txtSummary.TabIndex = 8;
            txtSummary.TextAlign = ContentAlignment.MiddleCenter;
            txtSummary.Click += txtSummary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(txtSummary);
            Controls.Add(btnClear);
            Controls.Add(btnSummarize);
            Controls.Add(txtHoursWorked);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblHoursWorked);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Name = "Form1";
            Text = "Assignment1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblHoursWorked;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtHoursWorked;
        private Button btnClear;
        private Label txtSummary;
        private Button btnSummarize;
    }
}
