using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormValidationExample.Views;

namespace FormValidationExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        internal void AddAnalogSignalView(AnalogSignalView view)
        {
            view.Dock = DockStyle.Fill;
            panel1.Controls.Add(view);
        }
    }
}
