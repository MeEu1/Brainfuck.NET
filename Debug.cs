using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brainfuck.NET
{
    public partial class Debug : Form
    {
        public void WriteOutput(string text)
        {
            txtB_Output.Text += text;
        }

        public Debug()
        {
            InitializeComponent();
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            txtB_Output.Clear();

            this.Close();
        }
    }
}
