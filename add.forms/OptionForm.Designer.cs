namespace add.forms
{
    partial class OptionForm
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
            checkBoxCsharp = new CheckBox();
            checkBoxPython = new CheckBox();
            checkBoxCpp = new CheckBox();
            checkBoxJava = new CheckBox();
            label1 = new Label();
            buttonOptionsContinue = new Button();
            buttonOptionsBack = new Button();
            SuspendLayout();
            // 
            // checkBoxCsharp
            // 
            checkBoxCsharp.Anchor = AnchorStyles.None;
            checkBoxCsharp.AutoSize = true;
            checkBoxCsharp.Location = new Point(120, 144);
            checkBoxCsharp.Name = "checkBoxCsharp";
            checkBoxCsharp.Size = new Size(104, 24);
            checkBoxCsharp.TabIndex = 0;
            checkBoxCsharp.Text = "C# module";
            checkBoxCsharp.UseVisualStyleBackColor = true;
            checkBoxCsharp.CheckedChanged += checkBoxCsharp_CheckedChanged;
            // 
            // checkBoxPython
            // 
            checkBoxPython.Anchor = AnchorStyles.None;
            checkBoxPython.AutoSize = true;
            checkBoxPython.Location = new Point(120, 180);
            checkBoxPython.Name = "checkBoxPython";
            checkBoxPython.Size = new Size(131, 24);
            checkBoxPython.TabIndex = 0;
            checkBoxPython.Text = "Python module";
            checkBoxPython.UseVisualStyleBackColor = true;
            checkBoxPython.CheckedChanged += checkBoxPython_CheckedChanged;
            // 
            // checkBoxCpp
            // 
            checkBoxCpp.Anchor = AnchorStyles.None;
            checkBoxCpp.AutoSize = true;
            checkBoxCpp.Location = new Point(120, 216);
            checkBoxCpp.Name = "checkBoxCpp";
            checkBoxCpp.Size = new Size(115, 24);
            checkBoxCpp.TabIndex = 0;
            checkBoxCpp.Text = "C++ module";
            checkBoxCpp.UseVisualStyleBackColor = true;
            checkBoxCpp.CheckedChanged += checkBoxCpp_CheckedChanged;
            // 
            // checkBoxJava
            // 
            checkBoxJava.Anchor = AnchorStyles.None;
            checkBoxJava.AutoSize = true;
            checkBoxJava.Location = new Point(120, 252);
            checkBoxJava.Name = "checkBoxJava";
            checkBoxJava.Size = new Size(114, 24);
            checkBoxJava.TabIndex = 0;
            checkBoxJava.Text = "Java module";
            checkBoxJava.UseVisualStyleBackColor = true;
            checkBoxJava.CheckedChanged += checkBoxJava_CheckedChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(330, 20);
            label1.TabIndex = 1;
            label1.Text = "Pleace choose optional modules for CodeWriter:";
            // 
            // buttonOptionsContinue
            // 
            buttonOptionsContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOptionsContinue.Location = new Point(276, 408);
            buttonOptionsContinue.Name = "buttonOptionsContinue";
            buttonOptionsContinue.Size = new Size(94, 29);
            buttonOptionsContinue.TabIndex = 2;
            buttonOptionsContinue.Text = "Continue";
            buttonOptionsContinue.UseVisualStyleBackColor = true;
            buttonOptionsContinue.Click += buttonOptionsContinue_Click;
            // 
            // buttonOptionsBack
            // 
            buttonOptionsBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonOptionsBack.Location = new Point(24, 408);
            buttonOptionsBack.Name = "buttonOptionsBack";
            buttonOptionsBack.Size = new Size(94, 29);
            buttonOptionsBack.TabIndex = 3;
            buttonOptionsBack.Text = "Back";
            buttonOptionsBack.UseVisualStyleBackColor = true;
            buttonOptionsBack.Click += buttonOptionsBack_Click;
            // 
            // OptionForm
            // 
            AcceptButton = buttonOptionsContinue;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonOptionsBack;
            ClientSize = new Size(391, 450);
            Controls.Add(buttonOptionsBack);
            Controls.Add(buttonOptionsContinue);
            Controls.Add(label1);
            Controls.Add(checkBoxJava);
            Controls.Add(checkBoxCpp);
            Controls.Add(checkBoxPython);
            Controls.Add(checkBoxCsharp);
            Name = "OptionForm";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxCsharp;
        private CheckBox checkBoxPython;
        private CheckBox checkBoxCpp;
        private CheckBox checkBoxJava;
        private Label label1;
        private Button buttonOptionsContinue;
        private Button buttonOptionsBack;
    }
}
