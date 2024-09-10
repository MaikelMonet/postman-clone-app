namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            urlLabel = new Label();
            apiTextBox = new TextBox();
            callApiButton = new Button();
            resultsTextBox = new TextBox();
            resultsLabel = new Label();
            statusStrip1 = new StatusStrip();
            systemStatusLabel = new ToolStripStatusLabel();
            systemStatusProgressBar = new ToolStripProgressBar();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            formHeader.AutoSize = true;
            formHeader.BackColor = Color.Transparent;
            formHeader.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(332, 9);
            formHeader.Margin = new Padding(2, 0, 2, 0);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(254, 45);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // urlLabel
            // 
            urlLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            urlLabel.AutoSize = true;
            urlLabel.BackColor = Color.Transparent;
            urlLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            urlLabel.Location = new Point(130, 76);
            urlLabel.Margin = new Padding(2, 0, 2, 0);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(61, 30);
            urlLabel.TabIndex = 1;
            urlLabel.Text = "URL :";
            urlLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // apiTextBox
            // 
            apiTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            apiTextBox.Location = new Point(185, 75);
            apiTextBox.Margin = new Padding(2);
            apiTextBox.Name = "apiTextBox";
            apiTextBox.Size = new Size(429, 29);
            apiTextBox.TabIndex = 2;
            // 
            // callApiButton
            // 
            callApiButton.Anchor = AnchorStyles.Top;
            callApiButton.BackColor = SystemColors.ButtonShadow;
            callApiButton.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            callApiButton.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            callApiButton.FlatStyle = FlatStyle.Flat;
            callApiButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            callApiButton.Location = new Point(618, 74);
            callApiButton.Margin = new Padding(2);
            callApiButton.Name = "callApiButton";
            callApiButton.Size = new Size(103, 32);
            callApiButton.TabIndex = 3;
            callApiButton.Text = "Call";
            callApiButton.UseVisualStyleBackColor = false;
            callApiButton.Click += callApiButton_Click;
            // 
            // resultsTextBox
            // 
            resultsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resultsTextBox.BackColor = SystemColors.Window;
            resultsTextBox.Location = new Point(185, 153);
            resultsTextBox.Margin = new Padding(2);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.ReadOnly = true;
            resultsTextBox.ScrollBars = ScrollBars.Both;
            resultsTextBox.Size = new Size(536, 304);
            resultsTextBox.TabIndex = 4;
            // 
            // resultsLabel
            // 
            resultsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = Color.Transparent;
            resultsLabel.Location = new Point(47, 156);
            resultsLabel.Margin = new Padding(2, 0, 2, 0);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(136, 21);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Incoming Results :";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.DarkGray;
            statusStrip1.Items.AddRange(new ToolStripItem[] { systemStatusLabel, systemStatusProgressBar });
            statusStrip1.Location = new Point(0, 494);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(851, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip";
            // 
            // systemStatusLabel
            // 
            systemStatusLabel.BackColor = Color.White;
            systemStatusLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatusLabel.Name = "systemStatusLabel";
            systemStatusLabel.Size = new Size(44, 17);
            systemStatusLabel.Text = "Ready";
            // 
            // systemStatusProgressBar
            // 
            systemStatusProgressBar.Name = "systemStatusProgressBar";
            systemStatusProgressBar.Size = new Size(100, 16);
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(851, 516);
            Controls.Add(statusStrip1);
            Controls.Add(resultsLabel);
            Controls.Add(resultsTextBox);
            Controls.Add(callApiButton);
            Controls.Add(apiTextBox);
            Controls.Add(urlLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Postman Clone Dashboard";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label urlLabel;
        private TextBox apiTextBox;
        private Button callApiButton;
        private TextBox resultsTextBox;
        private Label resultsLabel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel systemStatusLabel;
        private ToolStripProgressBar systemStatusProgressBar;
    }
}
