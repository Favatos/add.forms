namespace add.forms
{
    public partial class OptionForm : Form
    {
        public string[]? Options { get; set; }
        public OptionForm()
        {
            InitializeComponent();
            Options = new string[4];
        }

        private void checkBoxCsharp_CheckedChanged(object sender, EventArgs e)
        {
            Options[0] = checkBoxCsharp.Checked ? checkBoxCsharp.Text : null;
        }

        private void checkBoxPython_CheckedChanged(object sender, EventArgs e)
        {
            Options[1] = checkBoxPython.Checked ? checkBoxPython.Text : null;
        }

        private void checkBoxCpp_CheckedChanged(object sender, EventArgs e)
        {
            Options[2] = checkBoxCpp.Checked ? checkBoxCpp.Text : null;
        }

        private void checkBoxJava_CheckedChanged(object sender, EventArgs e)
        {
            Options[3] = checkBoxJava.Checked ? checkBoxJava.Text : null;
        }

        private void buttonOptionsBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonOptionsContinue_Click(object sender, EventArgs e)
        {
            StartForm.Options = Options;
            PathForm form = new PathForm();
            form.LoadText(StartForm.Path_);
            Visible = false;
            if(form.ShowDialog() == DialogResult.Cancel)
            {
                LoadOptions(Options);
            }
            Visible = true; 
        }

        public void LoadOptions(string[] options)
        {
            checkBoxCsharp.Checked = options[0] != null ? true : false;
            checkBoxPython.Checked = options[1] != null ? true : false;
            checkBoxCpp.Checked = options[2] != null ? true : false;
            checkBoxJava.Checked = options[3] != null ? true : false;
        }
    }
}
