using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModTemplateInstallWizard.Forms
{
    public partial class UserInputForm : Form
    {
        public string CustomMessage { get; private set; }

        public UserInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CustomMessage = this.textBox1.Text;
            this.Dispose();
        }
    }
}
