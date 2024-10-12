using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add.forms
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
            label1.Text = $"Modules: {string.Join(" ", StartForm.Options)}\n" +
                $"Instalation path: {StartForm.Path_}\n" +
                $"Preferences: {string.Join(' ', StartForm.Preferences)}";

        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            InstalationForm instalationForm = new InstalationForm();
            Visible = false;
            instalationForm.ShowDialog();
            Visible = true;

        }
    }
}
