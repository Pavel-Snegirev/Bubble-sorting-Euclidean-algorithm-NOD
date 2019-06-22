using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_10
{
    public partial class GeneralTask : Form
    {
        public GeneralTask()
        {
            InitializeComponent();
        }

        private void GeneralTask_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bubbles bub = new bubbles();
            this.Visible = false;
            bub.Show();
        }
    }
}
