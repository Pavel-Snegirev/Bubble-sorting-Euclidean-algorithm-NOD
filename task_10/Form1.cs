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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 77;
            int b = 131;
            int c;
            int d;
            int f;
            int l;
            int nod;
            int k;
            label5.Text = "Сформируем два первых числа последовательности : 131,77.\nДалее произведем деление с остатком этих чисел";
            c = b % a; //54
            label6.Text = "Остаток от деления чисел 131 и 77 равен" + " " + Convert.ToString(c);        
            d = a % c; //23
            label7.Text = "Остаток от деления чисел 77 и 54 равен" + " " + Convert.ToString(d);
            f = c % d; //8
            label8.Text = "Остаток от деления чисел 54 и 23 равен" + " " + Convert.ToString(f);
            l = d % f; //7
            label9.Text = "Остаток от деления чисел 23 и 8 равен" + " " + Convert.ToString(l);
            nod = f % l;//1
            label10.Text = "Остаток от деления чисел 8 и 7 равен" + " " + Convert.ToString(nod);
            k = l % nod;//0
            label11.Text = "Остаток от деления чисел 7 и 1 равен" + " " + Convert.ToString(k);
            label12.Text = "Сформированна конечная последовательность"+": "+Convert.ToString(c) + ", " + Convert.ToString(d) + ", " + Convert.ToString(f) + ", " + Convert.ToString(l) + ", " + Convert.ToString(nod) + ", " + Convert.ToString(k) + ", следовательно НОД равен" + Convert.ToString(nod);
            label4.Text = "Наибольший общий делитель равен" + " " + Convert.ToString(nod);
            label13.Dispose(); // при нажатии на кномпу данный метод удаляет label
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneralTask gen = new GeneralTask();
            this.Visible = false;
            gen.Show();

        }
    }
}
