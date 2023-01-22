using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_CourseWork
{
    public partial class DebugFrame : Form
    {
        public DebugFrame(string log)
        {
            InitializeComponent();
            AddLog(log);
        }

        public void AddLog(string Text)
        {
            DebugTextBox.Text = DebugTextBox.Text + Text + "\n";
        }

        private void DebugTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DebugFrame_Load(object sender, EventArgs e)
        {

        }
    }
}
