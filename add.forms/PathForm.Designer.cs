namespace add.forms
{
    partial class PathForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            buttonBrowse = new Button();
            buttonPathContinue = new Button();
            buttonPathBack = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 120);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Choose instalation path";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(192, 120);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Anchor = AnchorStyles.Right;
            buttonBrowse.Location = new Point(564, 120);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(94, 24);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "Browse";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonPathContinue
            // 
            buttonPathContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPathContinue.Location = new Point(552, 216);
            buttonPathContinue.Name = "buttonPathContinue";
            buttonPathContinue.Size = new Size(94, 29);
            buttonPathContinue.TabIndex = 3;
            buttonPathContinue.Text = "Continue";
            buttonPathContinue.UseVisualStyleBackColor = true;
            buttonPathContinue.Click += buttonPathContinue_Click;
            // 
            // buttonPathBack
            // 
            buttonPathBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPathBack.Location = new Point(36, 216);
            buttonPathBack.Name = "buttonPathBack";
            buttonPathBack.Size = new Size(94, 29);
            buttonPathBack.TabIndex = 4;
            buttonPathBack.Text = "Back";
            buttonPathBack.UseVisualStyleBackColor = true;
            buttonPathBack.Click += buttonPathBack_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // PathForm
            // 
            AcceptButton = buttonPathContinue;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonPathBack;
            ClientSize = new Size(680, 257);
            Controls.Add(buttonPathBack);
            Controls.Add(buttonPathContinue);
            Controls.Add(buttonBrowse);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "PathForm";
            Text = "PathForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button buttonBrowse;
        private Button buttonPathContinue;
        private Button buttonPathBack;
        private ErrorProvider errorProvider1;
    }
}