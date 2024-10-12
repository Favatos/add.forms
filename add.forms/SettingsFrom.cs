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
    public partial class SettingsFrom : Form
    {
        public string[]? Settings;
        public SettingsFrom()
        {
            InitializeComponent();
            Settings = new string[3];
        }

        private void checkBoxSubsribtion_CheckedChanged(object sender, EventArgs e)
        {
            Settings[0] = checkBoxSubsribtion.Checked ? checkBoxSubsribtion.Text : null;
        }

        private void checkBoxDesktopIcon_CheckedChanged(object sender, EventArgs e)
        {
            Settings[1] = checkBoxDesktopIcon.Checked ? checkBoxDesktopIcon.Text : null;
        }

        private void checkBoxRun_CheckedChanged(object sender, EventArgs e)
        {
            Settings[2] = checkBoxRun.Checked ? checkBoxRun.Text : null;
        }

        public void LoadSetting(string[] options)
        {
            checkBoxSubsribtion.Checked = options[0] != null ? true : false;
            checkBoxDesktopIcon.Checked = options[1] != null ? true : false;
            checkBoxRun.Checked = options[2] != null ? true : false;
        }

        private void buttonSettingContinue_Click(object sender, EventArgs e)
        {
            StartForm.Preferences = Settings;
            SumForm sumForm = new SumForm();
            Visible = false;
            sumForm.ShowDialog();
            Visible = true;
        }

        private void buttonSettingsBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            StartForm.Preferences = Settings;
            Close();
        }
    }
}
