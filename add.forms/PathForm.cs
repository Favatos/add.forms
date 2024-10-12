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
    public partial class PathForm : Form
    {
        public string Path { get; set; }
        public PathForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog ofd = new();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.SelectedPath;
                Path = ofd.SelectedPath;
            }
        }

        private void buttonPathContinue_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(buttonPathContinue, "Pleace choose instalation path");
                return;
            }
            else errorProvider1.Clear();
            StartForm.Path_ = textBox1.Text;
            SettingsFrom settingsFrom = new SettingsFrom();
            settingsFrom.LoadSetting(StartForm.Preferences);
            Visible = false;
            if(settingsFrom.ShowDialog() == DialogResult.Cancel)
            {
                LoadText(Path);
            }
            Visible = true;

        }

        public void LoadText(string path)
        {
            textBox1.Text = path;
        }

        private void buttonPathBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            StartForm.Path_ = textBox1.Text;
            Close();
        }
    }
}
