using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Brainfuck.NET
{
    public partial class Form1 : Form
    {
        Debug Dbg = new Debug();

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Run_Click(object sender, EventArgs e)
        {
            Token tkn;

            char[] code = txtB_Code.Text.Trim().ToCharArray();//Give the code written as a char array and remove spaces and "\n"s.

            if (txtB_Code.Text.Contains(','))
            {
                char[] input = txtB_Input.Text.ToCharArray();
                if (input.Length != 1)
                    throw new InvalidTokenExpressionException("Input bigger than expected");

                tkn = new Token(input[0]);
            }
            else
                tkn = new Token();
            try
            {
               Dbg.WriteOutput(tkn.SetOutput(code));
               Dbg.ShowDialog();
            }
            catch(TokenNotValidException ex)
            {
                MessageBox.Show(ex.Msg);
            }
            catch(InvalidTokenExpressionException ex)
            {
                MessageBox.Show(ex.Msg);
            }
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
