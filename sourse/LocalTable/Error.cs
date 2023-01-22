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
    public partial class Error : Form
    {
        public Error(string error)
        {
            InitializeComponent();
            ErrorText.Text = error;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Error_Load(object sender, EventArgs e)
        {

        }

        private void buttonError_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
