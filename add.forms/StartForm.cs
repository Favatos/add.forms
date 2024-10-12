using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add.forms
{
    public partial class StartForm : Form
    {
        static public string[]? Options { get; set; }
        static public string Path_ { get; set; }
        static public string[] Preferences { get; set; }
        public StartForm()
        {
            InitializeComponent();
            Options = new string[4];
            Preferences = new string[3];
        }

        private void buttonStartContinue_Click(object sender, EventArgs e)
        {
            OptionForm form = new();
            Visible = false;
            form.LoadOptions(Options);
            DialogResult result = form.ShowDialog();
            Visible = true;
            Options = form.Options;
            if(result == DialogResult.Cancel) { 
                form.Options = Options;
            }



        }
    }
}
