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
    public partial class bubbles : Form
    {
        public bubbles()
        {
            InitializeComponent();
        }

       
       
            
           
            private void button1_Click(object sender, EventArgs e)
            {
                    int i, j;
                    int k = 0;
                    int c = 0;
                    int n = 30;

                    int[] array = new int[n]; //ИСХОДНЫЙ МАССИВ
                    Random random = new Random();
                    for (i = 0; i < n; i++)
                    {
                       array[i] = random.Next(0, 30);
                       label4.Text = String.Join(" ", array);
                    }
           
                    for (i = 0; i < n - 1; i++)
                    {
                          for (j = 0; j < (n - 1 - i); j++)
                          {
                              k++; // количество сравнений
                                if (array[j] > array[j + 1])
                                {
                                  c = array[j];
                                  array[j] = array[j + 1];
                                  array[j + 1] = c;

                                }   
                          }
                    }

                     for (i = 0; i < n; i++) //отсортированный массив
                     {
                        label5.Text = String.Join(" ", array);
                     }

                        label7.Text = "КОЛИЧЕСТВО СРАВНЕНИЙ:" + "     " + Convert.ToString(k);
                        label9.Text = "КОЛИЧЕСТВО ПЕРЕСТАНОВОК:" +"     " + Convert.ToString(c);


            }

        private void button2_Click(object sender, EventArgs e)
        {
            task_10_2 ts2_10 = new task_10_2();
            this.Visible = false;
            ts2_10.Show();
        }
    }
}
