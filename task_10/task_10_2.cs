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
    public partial class task_10_2 : Form
    {
        public task_10_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int n = 10;
            int m = 20;
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            int[,] matrix = new int[n, m];
            Random r = new Random(100);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = r.Next(100);
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString();
                }
            }



            dataGridView2.RowCount = m;
            dataGridView2.ColumnCount = n;
            int[,] trans = new int[m, n];
           
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trans[i, j] = matrix[j, i];
                    dataGridView2.Rows[i].Cells[j].Value = trans[i, j].ToString();
                    //Console.Write(trans[i, j] + " \t ");
                }
               
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            this.Visible = false;
            fr.Show();

        }
    }
}
