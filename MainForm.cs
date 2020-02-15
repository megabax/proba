using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMyButton_Click(object sender, EventArgs e)
        {
            DemoClass dc = new DemoClass(3);
            MessageBox.Show(dc.field.ToString());
        }
    }
}
