namespace add.forms
{
    partial class SumForm
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
            label1 = new Label();
            buttonContinue = new Button();
            buttonCansel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // buttonContinue
            // 
            buttonContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonContinue.Location = new Point(684, 408);
            buttonContinue.Name = "buttonContinue";
            buttonContinue.Size = new Size(94, 29);
            buttonContinue.TabIndex = 1;
            buttonContinue.Text = "Continue";
            buttonContinue.UseVisualStyleBackColor = true;
            buttonContinue.Click += buttonContinue_Click;
            // 
            // buttonCansel
            // 
            buttonCansel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCansel.Location = new Point(12, 408);
            buttonCansel.Name = "buttonCansel";
            buttonCansel.Size = new Size(94, 29);
            buttonCansel.TabIndex = 1;
            buttonCansel.Text = "Back";
            buttonCansel.UseVisualStyleBackColor = true;
            buttonCansel.Click += buttonCansel_Click;
            // 
            // SumForm
            // 
            AcceptButton = buttonContinue;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCansel;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCansel);
            Controls.Add(buttonContinue);
            Controls.Add(label1);
            Name = "SumForm";
            Text = "SumForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonContinue;
        private Button buttonCansel;
    }
}