namespace add.forms
{
    partial class SettingsFrom
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
            checkBoxSubsribtion = new CheckBox();
            checkBoxDesktopIcon = new CheckBox();
            checkBoxRun = new CheckBox();
            buttonSettingsBack = new Button();
            buttonSettingContinue = new Button();
            SuspendLayout();
            // 
            // checkBoxSubsribtion
            // 
            checkBoxSubsribtion.Anchor = AnchorStyles.None;
            checkBoxSubsribtion.AutoSize = true;
            checkBoxSubsribtion.Location = new Point(84, 144);
            checkBoxSubsribtion.Name = "checkBoxSubsribtion";
            checkBoxSubsribtion.Size = new Size(150, 24);
            checkBoxSubsribtion.TabIndex = 0;
            checkBoxSubsribtion.Text = "Subscribe to news";
            checkBoxSubsribtion.UseVisualStyleBackColor = true;
            checkBoxSubsribtion.CheckedChanged += checkBoxSubsribtion_CheckedChanged;
            // 
            // checkBoxDesktopIcon
            // 
            checkBoxDesktopIcon.Anchor = AnchorStyles.None;
            checkBoxDesktopIcon.AutoSize = true;
            checkBoxDesktopIcon.Location = new Point(84, 192);
            checkBoxDesktopIcon.Name = "checkBoxDesktopIcon";
            checkBoxDesktopIcon.Size = new Size(184, 24);
            checkBoxDesktopIcon.TabIndex = 1;
            checkBoxDesktopIcon.Text = "Create icon on desktop";
            checkBoxDesktopIcon.UseVisualStyleBackColor = true;
            checkBoxDesktopIcon.CheckedChanged += checkBoxDesktopIcon_CheckedChanged;
            // 
            // checkBoxRun
            // 
            checkBoxRun.Anchor = AnchorStyles.None;
            checkBoxRun.AutoSize = true;
            checkBoxRun.Location = new Point(84, 240);
            checkBoxRun.Name = "checkBoxRun";
            checkBoxRun.Size = new Size(234, 24);
            checkBoxRun.TabIndex = 2;
            checkBoxRun.Text = "Run application after installing";
            checkBoxRun.UseVisualStyleBackColor = true;
            checkBoxRun.CheckedChanged += checkBoxRun_CheckedChanged;
            // 
            // buttonSettingsBack
            // 
            buttonSettingsBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSettingsBack.Location = new Point(12, 408);
            buttonSettingsBack.Name = "buttonSettingsBack";
            buttonSettingsBack.Size = new Size(94, 29);
            buttonSettingsBack.TabIndex = 3;
            buttonSettingsBack.Text = "Back";
            buttonSettingsBack.UseVisualStyleBackColor = true;
            buttonSettingsBack.Click += buttonSettingsBack_Click;
            // 
            // buttonSettingContinue
            // 
            buttonSettingContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSettingContinue.Location = new Point(264, 408);
            buttonSettingContinue.Name = "buttonSettingContinue";
            buttonSettingContinue.Size = new Size(94, 29);
            buttonSettingContinue.TabIndex = 3;
            buttonSettingContinue.Text = "Continue";
            buttonSettingContinue.UseVisualStyleBackColor = true;
            buttonSettingContinue.Click += buttonSettingContinue_Click;
            // 
            // SettingsFrom
            // 
            AcceptButton = buttonSettingContinue;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonSettingsBack;
            ClientSize = new Size(377, 450);
            Controls.Add(buttonSettingContinue);
            Controls.Add(buttonSettingsBack);
            Controls.Add(checkBoxRun);
            Controls.Add(checkBoxDesktopIcon);
            Controls.Add(checkBoxSubsribtion);
            Name = "SettingsFrom";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxSubsribtion;
        private CheckBox checkBoxDesktopIcon;
        private CheckBox checkBoxRun;
        private Button buttonSettingsBack;
        private Button buttonSettingContinue;
    }
}