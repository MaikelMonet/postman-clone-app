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
            statusStrip = new StatusStrip();
            systemStatusLabel = new ToolStripStatusLabel();
            actionDropDownList = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            bodyTextBox = new TextBox();
            outputTab = new TabPage();
            outputTextBox = new TextBox();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            outputTab.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            formHeader.AutoSize = true;
            formHeader.BackColor = Color.Transparent;
            formHeader.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(347, 9);
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
            urlLabel.Location = new Point(68, 70);
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
            apiTextBox.Location = new Point(251, 72);
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
            callApiButton.Location = new Point(685, 71);
            callApiButton.Margin = new Padding(2);
            callApiButton.Name = "callApiButton";
            callApiButton.Size = new Size(103, 32);
            callApiButton.TabIndex = 3;
            callApiButton.Text = "Call";
            callApiButton.UseVisualStyleBackColor = false;
            callApiButton.Click += callApiButton_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.DarkGray;
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatusLabel });
            statusStrip.Location = new Point(0, 817);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(884, 43);
            statusStrip.TabIndex = 7;
            statusStrip.Text = "statusStrip";
            // 
            // systemStatusLabel
            // 
            systemStatusLabel.BackColor = Color.White;
            systemStatusLabel.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatusLabel.Name = "systemStatusLabel";
            systemStatusLabel.Size = new Size(92, 38);
            systemStatusLabel.Text = "Ready";
            // 
            // actionDropDownList
            // 
            actionDropDownList.Anchor = AnchorStyles.Top;
            actionDropDownList.DropDownStyle = ComboBoxStyle.DropDownList;
            actionDropDownList.FormattingEnabled = true;
            actionDropDownList.Items.AddRange(new object[] { "GET", "POST" });
            actionDropDownList.Location = new Point(131, 71);
            actionDropDownList.Name = "actionDropDownList";
            actionDropDownList.Size = new Size(115, 29);
            actionDropDownList.TabIndex = 9;
            // 
            // callData
            // 
            callData.Anchor = AnchorStyles.Top;
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(outputTab);
            callData.Location = new Point(127, 122);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(661, 669);
            callData.TabIndex = 10;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(bodyTextBox);
            bodyTab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bodyTab.Location = new Point(4, 30);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(653, 635);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // bodyTextBox
            // 
            bodyTextBox.BackColor = SystemColors.Window;
            bodyTextBox.Dock = DockStyle.Fill;
            bodyTextBox.Location = new Point(3, 3);
            bodyTextBox.Margin = new Padding(2);
            bodyTextBox.Multiline = true;
            bodyTextBox.Name = "bodyTextBox";
            bodyTextBox.ScrollBars = ScrollBars.Both;
            bodyTextBox.Size = new Size(647, 629);
            bodyTextBox.TabIndex = 6;
            // 
            // outputTab
            // 
            outputTab.Controls.Add(outputTextBox);
            outputTab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputTab.Location = new Point(4, 30);
            outputTab.Name = "outputTab";
            outputTab.Padding = new Padding(3);
            outputTab.Size = new Size(653, 635);
            outputTab.TabIndex = 1;
            outputTab.Text = "Output";
            outputTab.UseVisualStyleBackColor = true;
            // 
            // outputTextBox
            // 
            outputTextBox.BackColor = SystemColors.Window;
            outputTextBox.Dock = DockStyle.Fill;
            outputTextBox.Location = new Point(3, 3);
            outputTextBox.Margin = new Padding(2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ReadOnly = true;
            outputTextBox.ScrollBars = ScrollBars.Both;
            outputTextBox.Size = new Size(647, 629);
            outputTextBox.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(884, 860);
            Controls.Add(callData);
            Controls.Add(actionDropDownList);
            Controls.Add(statusStrip);
            Controls.Add(callApiButton);
            Controls.Add(apiTextBox);
            Controls.Add(urlLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Postman Clone Dashboard";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            outputTab.ResumeLayout(false);
            outputTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label urlLabel;
        private TextBox apiTextBox;
        private Button callApiButton;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatusLabel;
        private ComboBox actionDropDownList;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage outputTab;
        private TextBox outputTextBox;
        private TextBox bodyTextBox;
    }
}
