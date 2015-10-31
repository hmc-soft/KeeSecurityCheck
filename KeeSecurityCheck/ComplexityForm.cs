using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeeSecurityCheck
{
    public partial class ComplexityForm : Form
    {
        public ComplexityForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text = Enum.GetName(typeof(PasswordScore), PasswordAdvisor.CheckStrength(passwordBox.Text));
        }
    }
}
